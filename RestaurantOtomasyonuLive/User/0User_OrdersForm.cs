using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static RestaurantOtomasyonuLive.StartScreen3;

namespace RestaurantOtomasyonuLive
{
    public partial class User_OrdersForm : Form
    {
        public User_OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // Başlangıçta son 30 günü seç
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-30);
            dateTimePickerTo.Value = DateTime.Today;
            LoadOrders();
        }

        private void LoadOrders()
        {
            string mail = KullaniciBilgileri.KullaniciData.Mail;
            DateTime from = dateTimePickerFrom.Value.Date;
            DateTime to = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1);

            
            var dt = new DataTable();
            using (var conn = new Connection2().Connect)
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT 
              o.order_id     AS [OrderID],
              o.order_date   AS [Tarih],
              o.total_amount AS [Tutar]
            FROM Orders o
            JOIN person p     ON o.person_id = p.person_id
            JOIN userLogin ul ON p.person_id = ul.person_id
            WHERE ul.mail = @mail
              AND o.order_date BETWEEN @from AND @to
            ORDER BY o.order_date DESC";
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", to);

                new SqlDataAdapter(cmd).Fill(dt);
            }

           
            var display = new DataTable();
            display.Columns.Add("No", typeof(int));       // ekranda gözükecek sıra numarası
            display.Columns.Add("Sipariş No", typeof(int));       // gerçek order_id
            display.Columns.Add("Tarih", typeof(DateTime));
            display.Columns.Add("Tutar", typeof(decimal));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var r = dt.Rows[i];
                display.Rows.Add(
                    i + 1,                         // No
                    r.Field<int>("OrderID"),       // Sipariş No = gerçek order_id
                    r.Field<DateTime>("Tarih"),
                    r.Field<decimal>("Tutar")
                );
            }

            dataGridViewOrders.DataSource = display;
        }



        private void btnFilter_Click(object sender, EventArgs e) => LoadOrders();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadOrders();

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;

            // artık buradan gerçeği çekiyoruz:
            int orderId = Convert.ToInt32(
                dataGridViewOrders.CurrentRow.Cells["Sipariş No"].Value);

            var detailsForm = new OrderDetailsForm(orderId);
            detailsForm.ShowDialog();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null) return;

            int orderId = Convert.ToInt32(
                dataGridViewOrders.CurrentRow.Cells["Sipariş No"].Value
            );

            if (MessageBox.Show(
                "Bu siparişi iptal etmek istediğinize emin misiniz?",
                "İptal Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) != DialogResult.Yes) return;

            using (var conn = new Connection2().Connect)
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            DELETE FROM OrderDetails WHERE order_id = @oid;
            DELETE FROM Orders       WHERE order_id = @oid;";
                cmd.Parameters.AddWithValue("@oid", orderId);
                cmd.ExecuteNonQuery();
            }

            
            LoadOrders();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new User_MainMenu().Show();
        }

        private void panelFilter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
