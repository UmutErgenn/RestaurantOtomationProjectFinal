using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestaurantOtomasyonuLive.StartScreen3;

namespace RestaurantOtomasyonuLive
{
    internal class sqlMethods4
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

        //kullanıcı bilgileri güncelleme sql metodu
        public static bool UpdateUserInfo(string mail, string ad, string soyad, string telefon, string sifre)
        {
            try
            {
                using (SqlConnection conn = new Connection().Connect)
                {
                    using (SqlCommand cmd = new SqlCommand("sp_GuncelleKullaniciBilgileri", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@soyad", soyad);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@sifre", sifre);
                        cmd.Parameters.AddWithValue("@mail", mail);

                        // Geri dönüş değeri parametresi
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;
                        cmd.Parameters.Add(returnValue);

                        cmd.ExecuteNonQuery();

                        int affectedRows = (int)returnValue.Value;

                        return affectedRows > 0; // Güncelleme başarılıysa true döner
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata mesajını döndürme
                MessageBox.Show("Hata: " + ex.Message);
                return false;
            }
        }

        //kullanıcı giriş yaptığında bilgileri doğrulayan ve kullanıcıya ait bilgileri tutan sql kodu

        // admin panelinde kullanıcıların listelendiği sql metodu
        public static DataTable getAllPersons()
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("getAllPersons_proc", connection.Connect);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //Admin kulanıcı silme işlemi için sql metodu
        public static bool deleteUser(int person_id)
        {
            try
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("delete_user_proc", connection.Connect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@person_id", person_id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
                return false;
            }
        }

        public static bool SendMessage(string mail, string subject, string messageBody)
        {
            try
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("send_message_proc", connection.Connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message_body", messageBody);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesaj gönderilemedi: " + ex.Message);
                return false;
            }
        }

        public static DataTable GetMessages()
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("get_messages_proc", connection.Connect);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataRow GetMessageDetail(int messageId)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("get_message_detail_proc", connection.Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@message_id", messageId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public List<(int Id, string UrunAdi, string GorselYolu, string UrunDescription, string UrunPrice)> UrunleriGetir()
        {
            var urunListesi = new List<(int, string, string, string, string)>();

            Connection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            try
            {
                connection = new Connection();
                if (connection.Connect.State != System.Data.ConnectionState.Open)
                    connection.Connect.Open();

                string query = "SELECT Id, UrunAdi, GorselYolu, urun_Description, urun_price FROM Urunler";

                cmd = new SqlCommand(query, connection.Connect);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]);
                    string urunAdi = reader["UrunAdi"].ToString();
                    string gorselYolu = reader["GorselYolu"].ToString();
                    string urunDescription = reader["urun_Description"].ToString();
                    string urunPrice = reader["urun_price"].ToString();

                    urunListesi.Add((id, urunAdi, gorselYolu, urunDescription, urunPrice));
                }
            }
            catch { }
            return urunListesi;
        }

        public bool UrunEkle(string urunAdi, string gorselYolu, string urunAciklama, string urunFiyat)
        {
            Connection connection = null;
            SqlCommand cmd = null;

            try
            {
                connection = new Connection();

                cmd = new SqlCommand("INSERT INTO Urunler (UrunAdi, GorselYolu, urun_Description, urun_price) " +
                                     "VALUES (@adi, @yol, @aciklama, @fiyat)", connection.Connect);

                cmd.Parameters.AddWithValue("@adi", urunAdi);
                cmd.Parameters.AddWithValue("@yol", gorselYolu);
                cmd.Parameters.AddWithValue("@aciklama", urunAciklama);
                cmd.Parameters.AddWithValue("@fiyat", urunFiyat);

                if (connection.Connect.State != System.Data.ConnectionState.Open)
                    connection.Connect.Open();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
