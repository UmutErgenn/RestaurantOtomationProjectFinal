using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    internal class sqlMethods2
    {
        public static bool login(string mail, string psswrd)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("login_proc", connection.Connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("mail", mail));
            cmd.Parameters.Add(new SqlParameter("psswrd", psswrd));

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int result = Convert.ToInt32(reader[0]);
                return result == 1; // 1 ise başarılı
            }
            else
            {
                return false;
            }
        }

        public static bool SignUp(string name, string surname, string mail, string password, string phone, string gender)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("signUp_proc", connection.Connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("surname", surname);
            cmd.Parameters.AddWithValue("mail", mail);
            cmd.Parameters.AddWithValue("psswrd", password);
            cmd.Parameters.AddWithValue("phone", Convert.ToDecimal(phone));
            if (gender == "Kadın"){
                cmd.Parameters.AddWithValue("gender", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("gender", 1);
            }
            cmd.ExecuteNonQuery();
            return true;
        }

        public static bool addCampaign(string campaignName, string campaignDescription, string campaignImagePath)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("add_Campaign_proc", connection.Connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("campaign_Name", campaignName);
            cmd.Parameters.AddWithValue("campaign_Description", campaignDescription);
            cmd.Parameters.AddWithValue("campaign_Image_Path", campaignImagePath);
            cmd.ExecuteNonQuery();
            return true;
        }

        public static bool addReservation(string mail,int tableNo,DateTime dateTime)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("addReservation_proc", connection.Connect);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("mail", mail);
            cmd.Parameters.AddWithValue("table_id", tableNo);
            cmd.Parameters.AddWithValue("reservation_date", dateTime);
            cmd.ExecuteNonQuery();
            return true;
        }
    }
}
