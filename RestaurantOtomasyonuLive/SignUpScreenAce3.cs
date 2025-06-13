using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class SignUpScreenAce3 : Form
    {
        Notification notification = new Notification();
        StartScreen3 startScreen = new StartScreen3();
        public SignUpScreenAce3()
        {
            InitializeComponent();
        }

        private void btn_signUpPerson_Click(object sender, EventArgs e)
        {
            // Boş bırakılma kontrolü
            if (string.IsNullOrWhiteSpace(txt_nameSignUp.Text) ||
                string.IsNullOrWhiteSpace(txt_surnameSignUp.Text) ||
                string.IsNullOrWhiteSpace(txt_mailSignUp.Text) ||
                string.IsNullOrWhiteSpace(txt_passwordSignUp.Text) ||
                string.IsNullOrWhiteSpace(txt_phoneNumSignUp.Text) ||
                string.IsNullOrWhiteSpace(combobox_genderSignUp.Text))
            {
                notification.showNotification(this, "Tüm alanları doldurunuz!", true);
                return;
            }

            // E-posta daha önce alınmış mı kontrolü
            if (sqlMethods4Ace3.IsEmailRegistered(txt_mailSignUp.Text))
            {
                notification.showNotification(this, "Bu e-posta adresi zaten kayıtlı!", true);
                return;
            }

            DialogResult onay = MessageBox.Show("Kayıt Eklensin Mi?", "Kayıt Ekleme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlMethods4Ace3.SignUp(
                        txt_nameSignUp.Text,
                        txt_surnameSignUp.Text,
                        txt_mailSignUp.Text,
                        txt_passwordSignUp.Text,
                        txt_phoneNumSignUp.Text,
                        combobox_genderSignUp.Text
                    );

                    notification.showNotification(this, "Kayıt eklendi", false);
                    startScreen.Show();
                    this.Hide();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                notification.showNotification(this, "Kayıt iptal edildi", false);
            }
        }

        private void btn_cancelSignUpForm_Click(object sender, EventArgs e)
        {
            startScreen.Show();
            this.Hide();
        }

        private void btn_signUpExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
