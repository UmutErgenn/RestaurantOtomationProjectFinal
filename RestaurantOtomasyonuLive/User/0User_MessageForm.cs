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
    public partial class User_MessageForm : Form
    {
        public User_MessageForm()
        {
            InitializeComponent();
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string mail = txt_Mail.Text;
            string subject = txt_Topic.Text;
            string message = rtxt_Message.Text;

            bool sent = sqlMethods4Ace3.SendMessage(mail, subject, message);
            if (sent)
                MessageBox.Show("Mesajınız gönderildi.");
            else 
                MessageBox.Show("Mesajınız gönderilemedi. Lütfen tekrar deneyin.");
        }

        public void LoadFormIntoPanel(Form form)
        {
            pnl_UserMessage.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnl_UserMessage.Controls.Add(form);
            form.Show();
        }

        private void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_CardForm());
        }

        private void pBox_AccountLogo_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_MyAccount());
        }

    }
}
