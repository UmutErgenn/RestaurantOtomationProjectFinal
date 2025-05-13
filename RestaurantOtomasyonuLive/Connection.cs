using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOtomasyonuLive
{
    internal class Connection
    {
        SqlConnection connect;
        String connString = "server=DESKTOP-GDM81IQ\\SQLEXPRESS; " +
               "database=RESTAURANT5; Trusted_Connection=True";
        //DESKTOP-GDM81IQ\SQLEXPRESS umut
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
