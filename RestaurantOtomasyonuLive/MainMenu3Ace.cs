using RestaurantOtomasyonuLive.RestaurantOtomasyonuLive;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static RestaurantOtomasyonuLive.StartScreen3;

namespace RestaurantOtomasyonuLive
{
    public partial class MainMenu3Ace : Form
    {
        public MainMenu3Ace()
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
                AdminFormAce2 adminForm = new AdminFormAce2();
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
            LoadFormIntoPanel(new SignUpScreenAce());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreenAce().Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new MainMenu3Ace().Show();
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
            UserMessageForm userMessageForm = new UserMessageForm();
            userMessageForm.Show();
            this.Hide();
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {

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
            CardForm cardForm = new CardForm();
            cardForm.Show();
            this.Hide();
        }

        private void btn_Menü_Click(object sender, EventArgs e)
        {
            MenuAce2 menuAce2 = new MenuAce2();
            this.Hide();
            menuAce2.Show();
        }
        private void btn_Siparişlerim_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new OrdersForm());
        }

        private void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            CardForm cardForm = new CardForm();
            cardForm.Show();
            this.Hide();
        }
    }
}