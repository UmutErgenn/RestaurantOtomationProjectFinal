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
    public partial class StartScreen : Form
    {
        Notification notification = new Notification();
        public StartScreen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Boş bırakma kontrolü
            if (string.IsNullOrWhiteSpace(txt_mail.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                notification.showNotification(this, "Mail ve şifre boş bırakılamaz!", true);
                return;
            }

            // Giriş işlemi
            if (sqlMethods.login(txt_mail.Text, txt_password.Text))
            {
                notification.showNotification(this, "Hoş geldiniz!", false);
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else // Hatalı giriş işlemi, var olmayan kullanıcı bilgileri
            {
                notification.showNotification(this, "Hatalı mail ya da şifre!", true);
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUpScreen signUpScreen = new SignUpScreen();
            signUpScreen.Show();
            this.Hide();
        }

        private void btn_loginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
