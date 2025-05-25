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
    public partial class AdminCampaignAce2 : Form
    {
        public static List<string> AdmincampaignNames = new List<string>();
        public static List<string> AdmincampaignDescriptions = new List<string>();
        public static List<string> AdmincampaignImagePaths = new List<string>();

        public AdminCampaignAce2()
        {
            InitializeComponent();
            start();
        }

        private void start()
        {
           
            AdmincampaignNames.Clear();
            AdmincampaignDescriptions.Clear();
            AdmincampaignImagePaths.Clear();

            
            var campaignSQL = new CampaignSQLAce();
            campaignSQL.getCampaigns();

           
            AdmincampaignNames.AddRange(CampaignSQLAce.campaignNames);
            AdmincampaignDescriptions.AddRange(CampaignSQLAce.campaignDescriptions);
            AdmincampaignImagePaths.AddRange(CampaignSQLAce.campaignImagePaths);

            
            int total = AdmincampaignNames.Count;

            
            var pics = new[] { pBoxAdmin_campaign1, pBoxAdmin_campaign2, pBoxAdmin_campaign3 };
            var heads = new[] { lbl_campaignHead1, lbl_campaignHead2, lbl_campaignHead3 };
            var texts = new[] { lbl_campaignText1, lbl_campaignText2, lbl_campaignText3 };

            
            for (int i = 0; i < Math.Min(total, pics.Length); i++)
            {
                pics[i].ImageLocation = AdmincampaignImagePaths[i];
                pics[i].SizeMode = PictureBoxSizeMode.StretchImage;
                heads[i].Text = AdmincampaignNames[i];
                texts[i].Text = AdmincampaignDescriptions[i];
            }
        }


        private void btn_signUpExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminCampaignEditAce2 adminCampaignEdit = new AdminCampaignEditAce2();
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
    }

}
