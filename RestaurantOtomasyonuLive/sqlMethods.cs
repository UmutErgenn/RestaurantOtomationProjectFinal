using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonuLive
{
    internal class sqlMethods
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
            if (gender == "kadın"){
                cmd.Parameters.AddWithValue("gender", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("gender", 1);
            }
            cmd.ExecuteNonQuery();
            return true;
        }

    }
}
