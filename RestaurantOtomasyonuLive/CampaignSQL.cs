using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    internal class CampaignSQL
    {
        public static List<string> campaignNames = new List<string>(); // Kampanya isimlerini tutar
        public static List<string> campaignDescriptions = new List<string>(); // Kampanya açıklamalarını tutar
        public static List<string> campaignImagePaths = new List<string>(); // Kampanya görsel yollarını tutar

        // Kampanyaları veritabanından alıp PictureBox ve Label'lara aktaran metod
        public void getCampaigns()
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("get_All_Campaigns_proc", connection.Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            int index = 0;

            while (reader.Read())
            {
                string campaignName = reader["campaign_Name"].ToString();
                string campaignDescription = reader["campaign_Description"].ToString();
                string campaignImagePath = reader["campaign_Image_Path"].ToString();

                campaignNames.Add(campaignName);
                campaignDescriptions.Add(campaignDescription);
                campaignImagePaths.Add(campaignImagePath);

                index++;
            }
            reader.Close();
        }
    }
}
