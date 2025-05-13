using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class ReservationForm : Form
    {
        Notification notification = new Notification();
        public ReservationForm()
        {
            InitializeComponent();
        }

        

        private void btn_add_reservation_Click(object sender, EventArgs e)
        {
            // Boş bırakılma kontrolü
            if (string.IsNullOrWhiteSpace(txt_name_info.Text) ||
                string.IsNullOrWhiteSpace(txt_surname_info.Text) ||
                string.IsNullOrWhiteSpace(txt_mail_info.Text) ||
                string.IsNullOrWhiteSpace(txt_table_No.Text) ||
                string.IsNullOrWhiteSpace(Convert.ToString(dateTimePicker_info.Value)))
            {
                notification.showNotification(this, "Tüm alanları doldurunuz!", true);
                return;
            }

            DialogResult onay = MessageBox.Show("Rezervasyon Sepete Eklensin Mi?", "Rezervasyon Ekleme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlMethods3.addReservation(
                        txt_mail_info.Text,
                        Convert.ToInt32(txt_table_No.Text),
                        dateTimePicker_info.Value
                        );

                    notification.showNotification(this, "Rezervasyon eklendi", false);
                    
                    Thread.Sleep(1000); 
                    pnl_RezervasyonOnay.Visible = false; 
                    pnl_RezervasyonOnay.Enabled = false; 
                    pnl_RezervasyonOnay.SendToBack();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                notification.showNotification(this, "Rezervasyon iptal edildi", false);
            }
        }

        private void btn_mainExit_Click(object sender, EventArgs e) {Application.Exit();}
        private void Table_1_Brown_Click(object sender, EventArgs e) {panelSet("1");}

        private void Table_2_Brown_Click(object sender, EventArgs e) {panelSet("2");}

        private void Table_3_Brown_Click(object sender, EventArgs e) {panelSet("3");}

        private void Table_4_Brown_Click(object sender, EventArgs e) {panelSet("4");}

        private void Table_5_Brown_Click(object sender, EventArgs e) {panelSet("5");}

        private void Table_6_Brown_Click(object sender, EventArgs e) {panelSet("6");}

        private void Table_7_Brown_Click(object sender, EventArgs e) {panelSet("7");}

        private void Table_8_Brown_Click(object sender, EventArgs e) {panelSet("8");}

        private void Table_9_Brown_Click(object sender, EventArgs e) {panelSet("9");}
        public void panelSet(String num) {
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
    }
}
