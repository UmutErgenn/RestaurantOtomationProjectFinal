using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonuLive
{
    internal  class Connection2
    {
        SqlConnection connect;
    
        //public static String connString = "server=DARKMATTER\\MSSQLSERVER01; " + "database=RESTAURANT; Trusted_Connection=True";
        public static String connString = "server=DESKTOP-GDM81IQ\\SQLEXPRESS; " + "database=RESTAURANT; Trusted_Connection=True";

        public SqlConnection Connect
        {
            get
            {
                if (connect == null)
                    connect = new SqlConnection(connString);

                if (connect.State != System.Data.ConnectionState.Open)
                    connect.Open();
                return connect;
            }
        }
        public String statue()
        {
            return connect.State.ToString();
        }
    }
}
