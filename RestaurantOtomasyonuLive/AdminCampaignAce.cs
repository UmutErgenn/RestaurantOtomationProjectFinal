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
    public partial class AdminCampaignAce : Form
    {
        public static List<string> AdmincampaignNames = new List<string>();
        public static List<string> AdmincampaignDescriptions = new List<string>();
        public static List<string> AdmincampaignImagePaths = new List<string>();

        public AdminCampaignAce()
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

            int totalCampaigns = AdmincampaignNames.Count;


            pBoxAdmin_campaign1.ImageLocation = AdmincampaignImagePaths[0];
            pBoxAdmin_campaign1.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_campaignHead1.Text = AdmincampaignNames[0];
            lbl_campaignText1.Text = AdmincampaignDescriptions[0];

            pBoxAdmin_campaign2.ImageLocation = AdmincampaignImagePaths[1];
            pBoxAdmin_campaign2.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_campaignHead2.Text = AdmincampaignNames[1];
            lbl_campaignText2.Text = AdmincampaignDescriptions[1];

            pBoxAdmin_campaign3.ImageLocation = AdmincampaignImagePaths[2];
            pBoxAdmin_campaign3.SizeMode = PictureBoxSizeMode.StretchImage;
            lbl_campaignHead3.Text = AdmincampaignNames[2];
            lbl_campaignText3.Text = AdmincampaignDescriptions[2];


        }

        private void btn_signUpExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminCampaignEditAce adminCampaignEdit = new AdminCampaignEditAce();
            adminCampaignEdit.Show();
        }

        private void pBoxAdmin_campaign3_Click(object sender, EventArgs e)
        {

        }
    }

}
