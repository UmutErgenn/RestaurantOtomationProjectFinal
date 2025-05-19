using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static RestaurantOtomasyonuLive.StartScreen3;

namespace RestaurantOtomasyonuLive
{
    public partial class MainMenu3 : Form
    {
        public MainMenu3()
        {
            InitializeComponent();
            form_Load();
        }

        private List<string> campaignNames = new List<string>();
        private List<string> campaignDescriptions = new List<string>();
        private List<string> campaignImagePaths = new List<string>();

        private void form_Load()
        {
            CampaignSQL campaignSQL = new CampaignSQL();
            campaignSQL.getCampaigns();

            campaignNames = CampaignSQL.campaignNames;
            campaignImagePaths = CampaignSQL.campaignImagePaths;
            campaignDescriptions = CampaignSQL.campaignDescriptions;

            // FlowLayoutPanel'i temizle
            flowLP_campaigns.Controls.Clear();

            // Maksimum 3 kampanya göster
            int maxToShow = Math.Min(3, campaignNames.Count);

            for (int i = 0; i < maxToShow; i++)
            {
                int index = i;

                // PictureBox oluştur
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = campaignImagePaths[index];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(187, 100);

                // Label oluştur
                Label label = new Label();
                label.Text = campaignNames[index];
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Bottom;
                label.Height = 30;
                label.Width = pictureBox.Width;
                label.Font = new Font("Arial", 10, FontStyle.Bold);
                label.Tag = index; // hangi kampanya olduğunu belirlemek için
                label.Cursor = Cursors.Hand;
                label.BackColor = Color.Transparent; // Arka planı şeffaf yap
                label.ForeColor = Color.White;       // Yazı rengini beyaz yap

                // Label'a click event bağla
                label.Click += DynamicCampaignLabel_Click;

                // Panel oluştur ve içine PictureBox + Label ekle
                Panel panel = new Panel();
                panel.Size = new Size(pictureBox.Width, pictureBox.Height + label.Height);
                pictureBox.Dock = DockStyle.Top;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.BackColor = Color.Transparent;

                // FlowLayoutPanel'e ekle
                flowLP_campaigns.Controls.Add(panel);
            }
                string role = KullaniciBilgileri.KullaniciData.Role;
            // Eğer kullanıcı "admin" değilse, admin panel butonunu gizle
            if (role.Equals("admin"))
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }

        }

        private void DynamicCampaignLabel_Click(object sender, EventArgs e)
        {
            if (sender is Label clickedLabel)
            {
                int index = (int)clickedLabel.Tag;

                if (index >= 0 && index < campaignNames.Count)
                {
                    MainMenu2Campaign detailForm = new MainMenu2Campaign();
                    detailForm.SetCampaignDetails(
                        campaignNames[index],
                        campaignDescriptions[index],
                        campaignImagePaths[index]
                    );
                    detailForm.Show();
                }
            }
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadFormIntoPanel(Form form)
        {
            PanelMenu.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SignUpScreen());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu3().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
            this.Hide();
        }

        private void pBox_AccountLogo_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            myAccount.Show();
            this.Close();
        }

         private void btn_Yardım_Click(object sender, EventArgs e)
         {   
             pnl_UserMessage.BringToFront();
             pnl_UserMessage.Visible = true;
             pnl_UserMessage.Enabled = true;

             PanelMenu.SendToBack();
             PanelMenu.Visible = false;
             PanelMenu.Enabled = false;
         }
        
        






        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string mail = txt_Mail.Text;
            string subject = txt_Topic.Text;
            string message = rtxt_Message.Text;

            bool sent = sqlMethods4.SendMessage(mail, subject, message);
            if (sent)
                MessageBox.Show("Mesajınız gönderildi.");
        }

        private void btn_Hakkımızda_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            AboutUserControl aboutUC = new AboutUserControl();
            PanelMenu.Controls.Add(aboutUC);
            aboutUC.Dock = DockStyle.Fill;
        }


    }
}
