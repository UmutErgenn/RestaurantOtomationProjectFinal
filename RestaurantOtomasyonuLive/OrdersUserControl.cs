using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class OrdersUserControl : UserControl
    {
        private readonly Connection2 conn = new Connection2();
        private readonly ContextMenuStrip ctxOrder = new ContextMenuStrip();

        public OrdersUserControl()
        {
            InitializeComponent();
            InitializeContextMenu();
            // Load olayı Designer aracılığıyla OrdersUserControl_Load metoduna bağlı
        }

        private void InitializeContextMenu()
        {
            ctxOrder.Items.Add("Onayla").Name = "mnuApprove";
            ctxOrder.Items.Add("İptal Et").Name = "mnuCancel";
            ctxOrder.Items.Add("Detay").Name = "mnuViewDetail";
            ctxOrder.ItemClicked += ctxOrder_ItemClicked;

            dgvOrders.CellMouseClick += dgvOrders_CellMouseClick;
            dgvOrders.Click += dgvOrders_Click;
        }

        // Designer’da this.Load += OrdersUserControl_Load olarak atanmalı
        private async void OrdersUserControl_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddDays(-7);
            await LoadOrdersAsync();
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            await LoadOrdersAsync(
                dtpStart.Value.Date,
                dtpEnd.Value.Date.AddDays(1).AddSeconds(-1),
                txtSearch.Text.Trim()
            );
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dtpStart.Value = DateTime.Today.AddDays(-7);
            dtpEnd.Value = DateTime.Today;
            await LoadOrdersAsync();
        }

        /// <summary>
        /// UI thread’i bloke etmeden sipariş listesini çeker ve DataGridView’e atar.
        /// </summary>
        private async Task LoadOrdersAsync(
            DateTime? start = null,
            DateTime? end = null,
            string search = "")
        {
            // 1) Arka planda DataTable’ı doldur
            var dt = await Task.Run(() =>
            {
                const string sql = @"
                    SELECT
                      o.order_id                     AS [Sipariş ID],
                      p.p_name + ' ' + p.p_surname   AS [Müşteri],
                      o.order_date                   AS [Tarih],
                      o.total_amount                 AS [Tutar],
                      o.order_status                 AS [Durum]
                    FROM Orders o
                    JOIN person p ON o.person_id = p.person_id
                    WHERE (@start IS NULL OR o.order_date >= @start)
                      AND (@end   IS NULL OR o.order_date <= @end)
                      AND (
                          CAST(o.order_id AS NVARCHAR(50)) LIKE '%' + @search + '%'
                          OR p.p_name + ' ' + p.p_surname LIKE '%' + @search + '%'
                      )
                    ORDER BY o.order_date DESC;";

                using (var cmd = new SqlCommand(sql, conn.Connect))
                {
                    cmd.Parameters.AddWithValue("@start", start.HasValue ? (object)start.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@end", end.HasValue ? (object)end.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@search", search);

                    var da = new SqlDataAdapter(cmd);
                    var table = new DataTable();
                    da.Fill(table);
                    return table;
                }
            });

            // 2) UI thread’de ata ve biçimlendir
            dgvOrders.DataSource = dt;
            dgvOrders.Columns["Tarih"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            dgvOrders.Columns["Tutar"].DefaultCellStyle.Format = "N2";

            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                var status = row.Cells["Durum"].Value as string;
                if (status == "Beklemede") row.DefaultCellStyle.BackColor = Color.Orange;
                else if (status == "Onaylandı") row.DefaultCellStyle.BackColor = Color.LightGreen;
                else if (status == "İptal Edildi") row.DefaultCellStyle.BackColor = Color.IndianRed;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void dgvOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.Button != MouseButtons.Left) return;

            dgvOrders.ClearSelection();
            dgvOrders.Rows[e.RowIndex].Selected = true;

            int id = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["Sipariş ID"].Value);
            LoadOrderDetails(id);

            ctxOrder.Show(dgvOrders, e.Location);
        }

        private void dgvOrders_Click(object sender, EventArgs e)
        {
            Point p = dgvOrders.PointToClient(Cursor.Position);
            var hit = dgvOrders.HitTest(p.X, p.Y);
            if (hit.Type != DataGridViewHitTestType.Cell || hit.RowIndex < 0)
            {
                dgvOrders.ClearSelection();
                dgvOrderDetails.DataSource = null;
            }
        }

        private async void ctxOrder_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvOrders.CurrentRow.Cells["Sipariş ID"].Value);

            switch (e.ClickedItem.Name)
            {
                case "mnuApprove":
                    await UpdateStatusAsync(id, "Onaylandı");
                    break;
                case "mnuCancel":
                    await UpdateStatusAsync(id, "İptal Edildi");
                    break;
                case "mnuViewDetail":
                    MessageBox.Show($"Sipariş #{id} detayları burada gösterilecek.");
                    break;
            }
        }

        /// <summary>
        /// Siparişin durumunu günceller ve ardından listeyi asenkron yeniler.
        /// </summary>
        private async Task UpdateStatusAsync(int orderId, string newStatus)
        {
            const string sql = "UPDATE Orders SET order_status = @st WHERE order_id = @id";
            using (var cmd = new SqlCommand(sql, conn.Connect))
            {
                cmd.Parameters.AddWithValue("@st", newStatus);
                cmd.Parameters.AddWithValue("@id", orderId);
                await cmd.ExecuteNonQueryAsync();
            }

            await LoadOrdersAsync();
        }

        private void LoadOrderDetails(int orderId)
        {
            const string sql = @"
                SELECT
                  od.detail_id                 AS [Detay ID],
                  u.UrunAdi                    AS [Ürün],
                  od.quantity                  AS [Adet],
                  od.unit_price                AS [Birim Fiyat],
                  od.quantity * od.unit_price  AS [Tutar]
                FROM OrderDetails od
                JOIN Urunler u ON od.urun_id = u.urun_id
                WHERE od.order_id = @oid;";

            using (var cmd = new SqlCommand(sql, conn.Connect))
            {
                cmd.Parameters.AddWithValue("@oid", orderId);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dgvOrderDetails.DataSource = dt;
            }
        }
    }
}
