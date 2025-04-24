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
        public StartScreen()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) //Login butonu kontrol kısmı
        {
            if (sqlMethods.login(txt_mail.Text, txt_password.Text))
            {
                MessageBox.Show("Hoş geldiniz");
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre.");
        }

        private void btn_signUp_Click(object sender, EventArgs e) //SignUp butonu - Kayıt olma kısmı kontrolü
        {
            SignUpForm signForm = new SignUpForm();
            signForm.Show();
            this.Hide();
        }
    }
}
