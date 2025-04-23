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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (sqlMethods.login(txt_mail.Text, txt_password.Text))
            {
                MessageBox.Show("hoş geldiniz");
                Form2 home = new Form2();
                home.Show();
                this.Hide();
            }

            else
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre.");
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUpForm signForm = new SignUpForm();
            signForm.Show();
            this.Hide();
        }
    }
}
