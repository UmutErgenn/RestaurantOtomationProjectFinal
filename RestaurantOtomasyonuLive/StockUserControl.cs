using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class StockUserControl : UserControl
    {
        
        private TextBox txtProductName, txtQuantity, txtUnit, txtCategory;
        private Label lblProductName, lblQuantity, lblUnit, lblCategory;

        public StockUserControl()
        {
            InitializeComponent();
            CenterPanel();
            this.Resize += (s, e) => { CenterPanel(); ArrangePanel(); };
            dgvStock.CellClick += dgvStock_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtUnit = new TextBox();
            txtCategory = new TextBox();

            lblProductName = new Label() { Text = "Ürün Adı", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter };
            lblQuantity = new Label() { Text = "Adet", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter };
            lblUnit = new Label() { Text = "Birim", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter };
            lblCategory = new Label() { Text = "Kategori", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter };

            // Panel'e ekle
            pnlContainer.Controls.Add(lblProductName);
            pnlContainer.Controls.Add(lblQuantity);
            pnlContainer.Controls.Add(lblUnit);
            pnlContainer.Controls.Add(lblCategory);
            pnlContainer.Controls.Add(txtProductName);
            pnlContainer.Controls.Add(txtQuantity);
            pnlContainer.Controls.Add(txtUnit);
            pnlContainer.Controls.Add(txtCategory);

            ArrangePanel(); 
            LoadStock();    
        }

        private void CenterPanel()
        {
            int parentWidth = this.Width;
            int parentHeight = this.Height;
            int panelWidth = pnlContainer.Width;
            int panelHeight = pnlContainer.Height;
            pnlContainer.Left = (parentWidth - panelWidth) / 2;
            pnlContainer.Top = (parentHeight - panelHeight) / 2;
        }

        private void ArrangePanel()
        {
            
            int panelWidth = pnlContainer.Width;
            int dgvBottom = dgvStock.Bottom;

            // TextBox ayarları
            int boxWidth = 120, boxHeight = 30, spacing = 25;
            int leftStart = (panelWidth - (4 * boxWidth + 3 * spacing)) / 2;
            int textTop = dgvBottom + 25;

            txtProductName.SetBounds(leftStart, textTop, boxWidth, boxHeight);
            txtQuantity.SetBounds(leftStart + boxWidth + spacing, textTop, boxWidth, boxHeight);
            txtUnit.SetBounds(leftStart + 2 * (boxWidth + spacing), textTop, boxWidth, boxHeight);
            txtCategory.SetBounds(leftStart + 3 * (boxWidth + spacing), textTop, boxWidth, boxHeight);

            // Label'lar
            int labelTop = textTop - 18;
            lblProductName.SetBounds(leftStart, labelTop, boxWidth, 18);
            lblQuantity.SetBounds(leftStart + boxWidth + spacing, labelTop, boxWidth, 18);
            lblUnit.SetBounds(leftStart + 2 * (boxWidth + spacing), labelTop, boxWidth, 18);
            lblCategory.SetBounds(leftStart + 3 * (boxWidth + spacing), labelTop, boxWidth, 18);

            
            int btnWidth = 110, btnHeight = 40, btnSpacing = 25;
            int btnTotalWidth = 3 * btnWidth + 2 * btnSpacing;
            int btnLeftStart = (panelWidth - btnTotalWidth) / 2;
            int btnTop = textTop + boxHeight + 20;

            btnAdd.SetBounds(btnLeftStart, btnTop, btnWidth, btnHeight);
            btnUpdate.SetBounds(btnLeftStart + btnWidth + btnSpacing, btnTop, btnWidth, btnHeight);
            btnDelete.SetBounds(btnLeftStart + 2 * (btnWidth + btnSpacing), btnTop, btnWidth, btnHeight);
        }

        private void LoadStock()
        {
            using (SqlConnection conn = new SqlConnection(Connection2.connString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT stock_id, product_name, quantity, unit, category FROM Stock", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStock.DataSource = dt;
            }
            
            dgvStock.Columns["stock_id"].Visible = false;
            dgvStock.Columns["product_name"].HeaderText = "Ürün";
            dgvStock.Columns["quantity"].HeaderText = "Adet";
            dgvStock.Columns["unit"].HeaderText = "Birim";
            dgvStock.Columns["category"].HeaderText = "Kategori";
            SetDgvStockProperties();
        }
        private void SetDgvStockProperties()
        {
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.AllowUserToAddRows = false;      // Kullanıcı yeni satır ekleyemesin
            dgvStock.AllowUserToDeleteRows = false;   // Kullanıcı satır silemesin
            dgvStock.MultiSelect = false;             // Çoklu seçim yok
            dgvStock.ReadOnly = true;                 // Satırlarda değişiklik yapılamasın

            // Sıralama iptal
            foreach (DataGridViewColumn col in dgvStock.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtQuantity.Text == "" || txtUnit.Text == "" || txtCategory.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurun!");
                return;
            }
            int quantity;
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                MessageBox.Show("Adet (Quantity) alanına geçerli bir sayı girin!");
                txtQuantity.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(Connection2.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Stock (product_name, quantity, unit, category) VALUES (@name, @qty, @unit, @cat)", conn);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim());
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Stok eklendi.");
            LoadStock();
            Temizle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow == null || dgvStock.CurrentRow.Cells["stock_id"].Value == null)
            {
                MessageBox.Show("Güncellenecek kaydı seçin.");
                return;
            }
            int stock_id = Convert.ToInt32(dgvStock.CurrentRow.Cells["stock_id"].Value);
            int quantity;
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity))
            {
                MessageBox.Show("Adet (Quantity) alanına geçerli bir sayı girin!");
                txtQuantity.Focus();
                return;
            }
            using (SqlConnection conn = new SqlConnection(Connection2.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Stock SET product_name=@name, quantity=@qty, unit=@unit, category=@cat WHERE stock_id=@id", conn);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@unit", txtUnit.Text.Trim());
                cmd.Parameters.AddWithValue("@cat", txtCategory.Text.Trim());
                cmd.Parameters.AddWithValue("@id", stock_id);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Stok güncellendi.");
            LoadStock();
            Temizle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow == null || dgvStock.CurrentRow.Cells["stock_id"].Value == null)
            {
                MessageBox.Show("Silinecek kaydı seçin.");
                return;
            }
            int stock_id = Convert.ToInt32(dgvStock.CurrentRow.Cells["stock_id"].Value);
            if (MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Connection2.connString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Stock WHERE stock_id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", stock_id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Stok silindi.");
                    LoadStock();
                    Temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız! " + ex.Message);
                }
            }
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtProductName.Text = dgvStock.Rows[e.RowIndex].Cells["product_name"].Value?.ToString();
                txtQuantity.Text = dgvStock.Rows[e.RowIndex].Cells["quantity"].Value?.ToString();
                txtUnit.Text = dgvStock.Rows[e.RowIndex].Cells["unit"].Value?.ToString();
                txtCategory.Text = dgvStock.Rows[e.RowIndex].Cells["category"].Value?.ToString();
            }
        }

        private void Temizle()
        {
            txtProductName.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
            txtCategory.Clear();
        }
    }
}
