using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class User_ReservationForm : Form
    {
        Notification notification = new Notification();

        public User_ReservationForm()
        {
            InitializeComponent();
            btn_add_reservation.Click += btn_add_reservation_Click;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            FillStartHourCombo();
            cmbEndHour.Items.Clear();
        }

        private void FillStartHourCombo()
        {
            cmbStartHour.Items.Clear();
            for (int hour = 12; hour <= 23; hour++)
            {
                cmbStartHour.Items.Add(hour.ToString("00") + ":00");
            }
            for (int hour = 0; hour < 12; hour++)
            {
                cmbStartHour.Items.Add(hour.ToString("00") + ":00");
            }
            cmbStartHour.SelectedIndex = -1;
            cmbEndHour.Items.Clear();
        }

        private void FillEndHourCombo()
        {
            cmbEndHour.Items.Clear();
            if (cmbStartHour.SelectedIndex == -1) return;
            int startHour = int.Parse(cmbStartHour.SelectedItem.ToString().Substring(0, 2));
            for (int hour = startHour + 1; hour <= 23; hour++)
            {
                cmbEndHour.Items.Add(hour.ToString("00") + ":00");
            }
            for (int hour = 0; hour < startHour; hour++)
            {
                cmbEndHour.Items.Add(hour.ToString("00") + ":00");
            }
            cmbEndHour.SelectedIndex = -1;
        }

        private void UpdateHourCombos()
        {
            // Seçili masa ve tarih alınır
            if (string.IsNullOrWhiteSpace(txt_table_No.Text)) return;
            int tableNo;
            if (!int.TryParse(txt_table_No.Text, out tableNo)) return;
            DateTime selectedDate = dateTimePicker_info.Value.Date;

            // Mevcut rezervasyonları kontrol et
            var reservedSlots = sqlMethods4Ace2.GetReservedTimeSlots(tableNo, selectedDate);

            // Tüm saatleri oluştur
            List<int> allHours = Enumerable.Range(0, 24).ToList();

            // Rezerve edilmiş saatleri çıkar
            HashSet<int> reservedHours = new HashSet<int>();
            foreach (var slot in reservedSlots)
            {
                int start = slot.Start.Hours;
                int end = slot.End.Hours;
                for (int h = start; h < end; h++)
                    reservedHours.Add(h % 24);
            }

            // Başlangıç saatleri: rezerve olmayanlar
            cmbStartHour.Items.Clear();
            foreach (int hour in allHours)
            {
                if (!reservedHours.Contains(hour))
                    cmbStartHour.Items.Add(hour.ToString("00") + ":00");
            }
            cmbStartHour.SelectedIndex = -1;
            cmbEndHour.Items.Clear();
        }

        private void dateTimePicker_info_ValueChanged(object sender, EventArgs e)
        {
            UpdateHourCombos();
        }

        private void txt_table_No_TextChanged(object sender, EventArgs e)
        {
            UpdateHourCombos();
        }

        private void cmbStartHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bitiş saatini güncelle
            cmbEndHour.Items.Clear();
            if (cmbStartHour.SelectedIndex == -1) return;
            int startHour = int.Parse(cmbStartHour.SelectedItem.ToString().Substring(0, 2));

            // Seçili masa ve tarih alınır
            if (string.IsNullOrWhiteSpace(txt_table_No.Text)) return;
            int tableNo;
            if (!int.TryParse(txt_table_No.Text, out tableNo)) return;
            DateTime selectedDate = dateTimePicker_info.Value.Date;
            var reservedSlots = sqlMethods4Ace2.GetReservedTimeSlots(tableNo, selectedDate);

            // Bitiş saatleri: başlangıçtan büyük ve rezerve olmayanlar
            for (int hour = startHour + 1; hour <= 23; hour++)
            {
                bool isReserved = reservedSlots.Any(slot =>
                    hour >= slot.Start.Hours && hour < slot.End.Hours
                );
                if (!isReserved)
                    cmbEndHour.Items.Add(hour.ToString("00") + ":00");
            }
            for (int hour = 0; hour < startHour; hour++)
            {
                bool isReserved = reservedSlots.Any(slot =>
                    hour >= slot.Start.Hours && hour < slot.End.Hours
                );
                if (!isReserved)
                    cmbEndHour.Items.Add(hour.ToString("00") + ":00");
            }
            cmbEndHour.SelectedIndex = -1;
        }

        private void btn_add_reservation_Click(object sender, EventArgs e)
        {
            // 1) Alan boş bırakılma kontrolü
            if (string.IsNullOrWhiteSpace(txt_name_info.Text) ||
                string.IsNullOrWhiteSpace(txt_surname_info.Text) ||
                string.IsNullOrWhiteSpace(txt_mail_info.Text) ||
                string.IsNullOrWhiteSpace(txt_table_No.Text) ||
                cmbStartHour.SelectedIndex == -1 ||
                cmbEndHour.SelectedIndex == -1)
            {
                notification.showNotification(this, "Tüm alanları doldurunuz!", true);
                return;
            }

            // 2) Tarih ve saatleri birleştir
            var date = dateTimePicker_info.Value.Date;
            int startHour = int.Parse(cmbStartHour.SelectedItem.ToString().Substring(0, 2));
            int endHour = int.Parse(cmbEndHour.SelectedItem.ToString().Substring(0, 2));
            var startDate = date.AddHours(startHour);
            var endDate = date.AddHours(endHour);

            // 3) Kullanıcı onayı
            var onay = MessageBox.Show(
                "Rezervasyon Sepete Eklensin Mi?",
                "Rezervasyon Ekleme",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (onay != DialogResult.Yes)
            {
                notification.showNotification(this, "Rezervasyon iptal edildi", false);
                return;
            }

            try
            {
                // 4) Rezervasyonu ekle (tek DateTime parametresi)
                int newResId = sqlMethods4Ace2.AddReservation(
                    txt_mail_info.Text,
                    int.Parse(txt_table_No.Text),
                    startDate
                );

                // 5) Sepete ekle (opsiyonel)
                bool ok = sqlMethods4Ace2.AddReservationToCart(AppSession.CartId, newResId);

                // 6) Geri bildirim
                if (newResId > 0)
                {
                    MessageBox.Show($"Rezervasyon sepete eklendi. ID: {newResId}");
                    pnl_RezervasyonOnay.Visible = false;
                    pnl_RezervasyonOnay.Enabled = false;
                    pnl_RezervasyonOnay.SendToBack();
                }
                else
                {
                    MessageBox.Show("Rezervasyon eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_mainExit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void Table_1_Brown_Click(object sender, EventArgs e) { panelSet("1"); }

        private void Table_2_Brown_Click(object sender, EventArgs e) { panelSet("2"); }

        private void Table_3_Brown_Click(object sender, EventArgs e) { panelSet("3"); }

        private void Table_4_Brown_Click(object sender, EventArgs e) { panelSet("4"); }

        private void Table_5_Brown_Click(object sender, EventArgs e) { panelSet("5"); }

        private void Table_6_Brown_Click(object sender, EventArgs e) { panelSet("6"); }

        private void Table_7_Brown_Click(object sender, EventArgs e) { panelSet("7"); }

        private void Table_8_Brown_Click(object sender, EventArgs e) { panelSet("8"); }

        private void Table_9_Brown_Click(object sender, EventArgs e) { panelSet("9"); }
        public void panelSet(String num)
        {
            pnl_RezervasyonOnay.BringToFront();
            pnl_RezervasyonOnay.Visible = true;
            pnl_RezervasyonOnay.Enabled = true;

            txt_table_No.Text = num;
        }

        private void btn_close_reserv_info_Click(object sender, EventArgs e)
        {
            pnl_RezervasyonOnay.SendToBack();
            pnl_RezervasyonOnay.Visible = false;
            pnl_RezervasyonOnay.Enabled = false;
        }

        private void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            User_CardForm cardForm = new User_CardForm();
            cardForm.Show();
            this.Hide();
        }

        private void btn_Ana_Menü_Click(object sender, EventArgs e)
        {
            User_MainMenu mainMenu = new User_MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_Menü_Click(object sender, EventArgs e)
        {
            User_MenuHome menuAce2 = new User_MenuHome();
            menuAce2.Show();
            this.Hide();
        }

        private void btn_Siparişlerim_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
            this.Hide();
        }

        private void btn_Yardım_Click(object sender, EventArgs e)
        {
            UserMessageForm userMessageForm = new UserMessageForm();
            userMessageForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
