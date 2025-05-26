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
    public partial class UserMessageForm : Form
    {
        public UserMessageForm()
        {
            InitializeComponent();
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string mail = txt_Mail.Text;
            string subject = txt_Topic.Text;
            string message = rtxt_Message.Text;

            bool sent = sqlMethods4Ace2.SendMessage(mail, subject, message);
            if (sent)
                MessageBox.Show("Mesajınız gönderildi.");
            else 
                MessageBox.Show("Mesajınız gönderilemedi. Lütfen tekrar deneyin.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CardForm cardForm = new CardForm();
            cardForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
            this.Hide();
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ana_Menü_Click(object sender, EventArgs e)
        {
            MainMenu3Ace mainMenu = new MainMenu3Ace();
            mainMenu.Show();
            this.Hide();
        }
    }
}
