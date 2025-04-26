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
    public partial class SignUpScreen : Form
    {
        Notification notification = new Notification();
        StartScreen startScreen = new StartScreen();
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

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

            DialogResult onay = MessageBox.Show("Kayıt Eklensin Mi?", "Kayıt Ekleme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlMethods.SignUp(
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
