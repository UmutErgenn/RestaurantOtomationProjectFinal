using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class User_CardForm : Form
    {
        public User_CardForm()
        {
            InitializeComponent();
        }

        private void CardForm_Load(object sender, EventArgs e)
        {
            LoadCart();
            StilizeDataGridView();
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
        }

        private void LoadCart()
        {
            // 1) Sepeti çek
            DataTable dt = sqlMethods4Ace2.GetCartContents(AppSession.CartId);

            // 2) DataGridView'e ata
            dataGridView3.DataSource = dt;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ReadOnly = true;

            // 3) Toplam tutarı hesapla
            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["ItemType"].ToString() == "Meal")
                    total += Convert.ToInt32(row["Quantity"]) * Convert.ToDecimal(row["UnitPrice"]);
                else if (row["ItemType"].ToString() == "Reservation")
                    total += 100m; // sabit rezervasyon ücreti
            }
            lbl_total.Text = $"Toplam: {total:C}";
        }

        private void StilizeDataGridView()
        {
            // Genel Ayarlar
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(44, 44, 44);
            dataGridView3.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView3.DefaultCellStyle.ForeColor = Color.White;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView3.RowHeadersVisible = false;

            // Başlık (Header) Ayarları
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView3.EnableHeadersVisualStyles = false;

            // Gridline ve diğer
            dataGridView3.GridColor = Color.Gray;
            dataGridView3.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToResizeRows = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.ReadOnly = true;

            dataGridView3.DataSource = sqlMethods4Ace2.GetCartContents(AppSession.CartId);
            dataGridView3.Columns["ItemType"].HeaderText = "Tür";
            dataGridView3.Columns["ItemId"].HeaderText = "No";
            dataGridView3.Columns["UrunAdi"].HeaderText = "Yemek Adı";
            dataGridView3.Columns["Quantity"].HeaderText = "Adet";
            dataGridView3.Columns["UnitPrice"].HeaderText = "Birim Fiyat";
        }

        private void btn_card_approve_Click(object sender, EventArgs e)
        {
            int orderId = sqlMethods4Ace2.ConfirmCart(AppSession.CartId);

            if (orderId > 0)
                MessageBox.Show($"Sipariş başarıyla oluşturuldu. Sipariş No: {orderId}",
                                "Başarılı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            else
                MessageBox.Show("Sipariş onaylanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CardForm_Load(sender, e);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir satır seçin.");
                return;
            }

            var row = dataGridView3.SelectedRows[0];
            string type = row.Cells["ItemType"].Value.ToString();      // SP’deki alias
            int itemId = Convert.ToInt32(row.Cells["ItemId"].Value);

            bool ok = false;
            if (type == "Reservation")
            {
                ok = sqlMethods4Ace2.RemoveReservationFromCart(AppSession.CartId);
            }
            else if (type == "Meal")
            {
                ok = sqlMethods4Ace2.RemoveMealFromCart(AppSession.CartId, itemId);
            }

            if (ok)
            {
                MessageBox.Show("Sepetten çıkarıldı.");
                LoadCart();   // Sepeti yeniden yükle
            }
            else
            {
                MessageBox.Show("Çıkarma işlemi başarısız.");
            }
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0) return;
            var row = dataGridView3.SelectedRows[0];
            if (row.Cells["ItemType"].Value.ToString() != "Meal") return; // sadece yemekler için

            int urunId = Convert.ToInt32(row.Cells["ItemId"].Value);
            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value) + 1;

            if (sqlMethods4Ace2.UpdateMealQuantity(AppSession.CartId, urunId, quantity))
                LoadCart();
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0) return;
            var row = dataGridView3.SelectedRows[0];
            if (row.Cells["ItemType"].Value.ToString() != "Meal") return; // sadece yemekler için

            int urunId = Convert.ToInt32(row.Cells["ItemId"].Value);
            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value) - 1;
            if (quantity < 1) return; // 0 veya altı yasak

            if (sqlMethods4Ace2.UpdateMealQuantity(AppSession.CartId, urunId, quantity))
                LoadCart();
        }

        private void btn_Ana_Menü_Click(object sender, EventArgs e)
        {
            User_MainMenu mainMenu = new User_MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_Menü_Click(object sender, EventArgs e)
        {
            User_MenuHome menu = new User_MenuHome();
            menu.Show();
            this.Hide();
        }

        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
            User_ReservationForm reservationForm = new User_ReservationForm();
            reservationForm.Show();
            this.Hide();
        }
    }
}
