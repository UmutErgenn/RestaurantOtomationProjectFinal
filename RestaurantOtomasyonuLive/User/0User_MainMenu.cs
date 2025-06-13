using RestaurantOtomasyonuLive.RestaurantOtomasyonuLive;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static RestaurantOtomasyonuLive.StartScreen3;

namespace RestaurantOtomasyonuLive
{
    public partial class User_MainMenu : Form
    {
        public User_MainMenu()
        {
            InitializeComponent();
            form_Load();

            this.btn_Siparişlerim.Click += new EventHandler(this.btn_Siparişlerim_Click);
        }

        private List<string> campaignNames = new List<string>();
        private List<string> campaignDescriptions = new List<string>();
        private List<string> campaignImagePaths = new List<string>();

        private void form_Load()
        {
            // Kampanyaları SQL'den al
            CampaignSQLAce campaignSQL = new CampaignSQLAce();
            campaignSQL.getCampaigns();

            campaignNames = CampaignSQLAce.campaignNames;
            campaignImagePaths = CampaignSQLAce.campaignImagePaths;
            campaignDescriptions = CampaignSQLAce.campaignDescriptions;

            // FlowLayoutPanel'i temizle
            flowLP_campaigns.Controls.Clear();

            // Maksimum 3 kampanya göster
            int maxToShow = Math.Min(3, campaignNames.Count);
            int panelWidth = 187; // Kampanya görseli genişliği
            int panelMargin = 10;
            int totalPanelWidth = (panelWidth + panelMargin * 2) * maxToShow;

            // Ortalamayı sağlamak için boşluk paneli ekle
            int paddingLeft = (flowLP_campaigns.Width - totalPanelWidth) / 2;
            if (paddingLeft < 0) paddingLeft = 0;

            Panel spacer = new Panel();
            spacer.Width = paddingLeft;
            spacer.Height = 1;
            flowLP_campaigns.Controls.Add(spacer);

            for (int i = 0; i < maxToShow; i++)
            {
                // PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.ImageLocation = campaignImagePaths[i];
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(panelWidth, 100);
                pictureBox.Dock = DockStyle.Top;

                // Label
                Label label = new Label();
                label.Text = campaignNames[i];
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Bottom;
                label.Height = 30;
                label.Width = panelWidth;
                label.Font = new Font("Arial", 10, FontStyle.Bold);
                label.Tag = i;
                label.Cursor = Cursors.Hand;
                label.BackColor = Color.Transparent;
                label.ForeColor = Color.White;
                label.Click += DynamicCampaignLabel_Click;

                // Panel
                Panel panel = new Panel();
                panel.Size = new Size(panelWidth, pictureBox.Height + label.Height);
                panel.Margin = new Padding(panelMargin);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.BackColor = Color.Transparent;

                flowLP_campaigns.Controls.Add(panel);
            }

            // Kullanıcı admin ise AdminForm'a geç
            string role = KullaniciBilgileri.KullaniciData.Role;
            if (role.Equals("admin"))
            {
                AdminFormAce3 adminForm = new AdminFormAce3();
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

        public void LoadFormIntoPanel(Form form)
        {
            PanelMenu.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            PanelMenu.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new SignUpScreenAce3());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreenAce3().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new User_MainMenu().Show();
        }

        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_ReservationForm());
        }

        private void btn_Yardım_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_MessageForm());
        }

        private void btn_Hakkımızda_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            AboutUserControl aboutUC = new AboutUserControl();
            PanelMenu.Controls.Add(aboutUC);
            aboutUC.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_CardForm());
        }

        private void btn_Menü_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_MenuHome());
        }
        private void btn_Siparişlerim_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_OrdersForm());
        }

        public void pBox_AccountLogo_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_MyAccount());
        }

        public void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_CardForm());
        }
    }
}