using RestaurantOtomasyonuLive.RestaurantOtomasyonuLive;
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
    public partial class Admin_Campaign : Form
    {
        public static List<string> AdmincampaignNames = new List<string>();
        public static List<string> AdmincampaignDescriptions = new List<string>();
        public static List<string> AdmincampaignImagePaths = new List<string>();

        public Admin_Campaign()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
            CampaignSQLAce campaignSQL = new CampaignSQLAce();
            campaignSQL.getCampaigns();

            AdmincampaignNames.AddRange(CampaignSQLAce.campaignNames);
            AdmincampaignDescriptions.AddRange(CampaignSQLAce.campaignDescriptions);
            AdmincampaignImagePaths.AddRange(CampaignSQLAce.campaignImagePaths);

            // Kampanya sayısını al
            int totalCampaigns = AdmincampaignNames.Count;

            if (totalCampaigns > 0)
            {
                pBoxAdmin_campaign1.ImageLocation = AdmincampaignImagePaths[0];
                pBoxAdmin_campaign1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_campaignHead1.Text = AdmincampaignNames[0];
                lbl_campaignText1.Text = AdmincampaignDescriptions[0];
            }

            if (totalCampaigns > 1)
            {
                pBoxAdmin_campaign2.ImageLocation = AdmincampaignImagePaths[1];
                pBoxAdmin_campaign2.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_campaignHead2.Text = AdmincampaignNames[1];
                lbl_campaignText2.Text = AdmincampaignDescriptions[1];
            }

            if (totalCampaigns > 2)
            {
                pBoxAdmin_campaign3.ImageLocation = AdmincampaignImagePaths[2];
                pBoxAdmin_campaign3.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_campaignHead3.Text = AdmincampaignNames[2];
                lbl_campaignText3.Text = AdmincampaignDescriptions[2];
            }
        }

        private void btn_signUpExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_CampaignEdit adminCampaignEdit = new Admin_CampaignEdit();
            adminCampaignEdit.Show();
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_campaignHead1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_campaignText2_Click(object sender, EventArgs e)
        {

        }

        private void pBoxAdmin_campaign2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Admin_Menu admin_Menu = new Admin_Menu();
            admin_Menu.Show();
            this.Hide();
        }

        private void btn_Staffs_Click(object sender, EventArgs e)
        {
            Admin_Personel admin_Personel = new Admin_Personel();
            admin_Personel.Show();
            this.Hide();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Admin_Users admin_Users = new Admin_Users();
            admin_Users.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Close();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();
            var ordersUC = new OrdersUserControl { Dock = DockStyle.Fill };
            panelMenu.Controls.Add(ordersUC);
        }
    }

}
