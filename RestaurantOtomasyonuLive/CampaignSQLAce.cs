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
    namespace RestaurantOtomasyonuLive
    {
        internal class CampaignSQLAce
        {
            public static List<string> campaignNames = new List<string>();
            public static List<string> campaignDescriptions = new List<string>();
            public static List<string> campaignImagePaths = new List<string>();

            public void getCampaigns()
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("get_All_Campaigns_proc", connection.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    campaignNames.Add(reader["campaign_Name"].ToString());
                    campaignDescriptions.Add(reader["campaign_Description"].ToString());
                    campaignImagePaths.Add(reader["campaign_Image_Path"].ToString());
                }
                reader.Close();
            }

            public bool addCampaign(string name, string description, string imagePath)
            {
                try
                {
                    Connection connection = new Connection();
                    SqlCommand cmd = new SqlCommand("add_Campaign_proc", connection.Connect);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@campaign_Name", name);
                    cmd.Parameters.AddWithValue("@campaign_Description", description);
                    cmd.Parameters.AddWithValue("@campaign_Image_Path", imagePath);

                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}