using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;


namespace RestaurantOtomasyonuLive
{

    internal class sqlMethods4

    {
        public static bool login(string mail, string psswrd)
        {
            using (SqlConnection connString = new SqlConnection(Connection.connString))
            {
                connString.Open();
                SqlCommand cmd = new SqlCommand("login_proc", connString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@psswrd", psswrd);
                var sonuc = cmd.ExecuteScalar();
                return sonuc != null && Convert.ToInt32(sonuc) == 1;
            }
        }

        public static bool SignUp(string name, string surname, string mail, string password, string phone, string gender)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("signUp_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@psswrd", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender == "Kadın" ? 0 : 1);
                var sonuc = cmd.ExecuteScalar();
                return sonuc != null && Convert.ToInt32(sonuc) == 1;
            }
        }

        public static int addReservation(string mail, int tableNo, DateTime dateTime)
        {
            int newResId = -1;
            try
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("addReservation_proc", connection.Connect);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("mail", mail);
                cmd.Parameters.AddWithValue("table_id", tableNo);
                cmd.Parameters.AddWithValue("reservation_date", dateTime);

                var outParam = new SqlParameter("@newResId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);
                cmd.ExecuteNonQuery();
                newResId = (int)outParam.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon eklenirken hata: " + ex.Message);
            }

            return newResId;
        }

        public static bool UpdateUserInfo(string mail, string ad, string soyad, string telefon, string sifre)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GuncelleKullaniciBilgileri", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@telefon", telefon);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@mail", mail);
                SqlParameter returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(returnValue);
                cmd.ExecuteNonQuery();
                int affectedRows = (int)returnValue.Value;
                return affectedRows > 0;
            }
        }

        public static DataTable getAllPersons()
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("getAllPersons_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static bool deleteUser(int person_id)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete_user_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@person_id", person_id);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public static bool SendMessage(string mail, string subject, string messageBody)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("send_message_proc", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message_body", messageBody);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        // ÖRNEK: İstatistik fonksiyonları
        public static int GetToplamSatis()
        {
            int toplam = 0;
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ToplamSatis", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                    toplam = Convert.ToInt32(sonuc);
            }
            return toplam;
        }

        public static int GetToplamSiparis()
        {
            int toplam = 0;
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders", conn);
                var sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                    toplam = Convert.ToInt32(sonuc);
            }
            return toplam;
        }

        public static int GetToplamKullanici()
        {
            int toplam = 0;
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MusteriSayisi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                    toplam = Convert.ToInt32(sonuc);
            }
            return toplam;
        }

        public static int GetToplamRezervasyon()
        {
            int toplam = 0;
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_RezervasyonSayisi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var sonuc = cmd.ExecuteScalar();
                if (sonuc != null && sonuc != DBNull.Value)
                    toplam = Convert.ToInt32(sonuc);
            }
            return toplam;
        }

        public static DataTable GetAylikSatis()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_AylikSatis", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public static string GetTopMenu()
        {
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetTopMenu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["UrunAdi"].ToString();
                }
                else
                {
                    return "Veri yok";
                }
            }
        }

        public static DataTable GetHaftalikSiparis()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Connection.connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_GetHaftalikSiparis", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
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


        // 2) Rezervasyonu sepete ekle
        public static bool AddReservationToCart(int cartId, int reservationId)
        {
            try
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("cart_AddReservation", connection.Connect) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@cartId", cartId);
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // 3) Yemeği sepete ekle
        public static bool AddMealToCart(int cartId, string mealName, int quantity)
        {
            try
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("cart_AddMeal", connection.Connect) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@cartId", cartId);
                cmd.Parameters.AddWithValue("@mealName", mealName);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }

        // 4) Sepet içeriğini al
        public static DataTable GetCartContents(int cartId)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("cart_GetContents", connection.Connect) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@cartId", cartId);

            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




        // Sepeti onayla ve sipariş ID’sini döndür
        public static int ConfirmCart(int cartId)
        {
            int newOrderId = -1;

            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("cart_Confirm", connection.Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Input parametre
                cmd.Parameters.AddWithValue("@cartId", cartId);

                // Output parametre
                SqlParameter outputParam = new SqlParameter("@newOrderId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                try
                {
                    cmd.ExecuteNonQuery();

                    // Sipariş ID’sini al
                    newOrderId = (int)outputParam.Value;
                }
                catch (Exception ex)
                {
                    // Hata yönetimi
                    MessageBox.Show("Sipariş onaylanırken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return newOrderId;
        }

        // sepet içeriğini db'den çekiyoruz
        public DataTable GetCartContentsForCardLoad(int cartId)
        {
            Connection connection = new Connection();
            SqlCommand cmd = new SqlCommand("cart_GetContents", connection.Connect);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cartId", cartId);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Sepeti al ya da oluştur
        public static int GetOrCreateCart(string mail)
        {
            int cartId = -1;
            try
            {
                Connection connection = new Connection();
                SqlCommand cmd = new SqlCommand("sp_GetOrCreateCart", connection.Connect)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@mail", mail);
                var outParam = new SqlParameter("@cartId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();
                cartId = (int)outParam.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sepet alınırken hata: " + ex.Message);
            }
            return cartId;
        }


        // Rezervasyonu kaldır
        public static bool RemoveReservationFromCart(int cartId)
        {
            try
            {
                Connection conn = new Connection();
                SqlCommand cmd = new SqlCommand("cart_RemoveReservation", conn.Connect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cartId", cartId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // Şimdi hatayı göreceksin
                MessageBox.Show("Hata(Rezervasyon silme): " + ex.Message);
                return false;
            }
        }

        // Yemek kalemini kaldır
        public static bool RemoveMealFromCart(int cartId, int urunId)
        {
            try
            {
                Connection conn = new Connection();
                SqlCommand cmd = new SqlCommand("cart_RemoveMeal", conn.Connect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@cartId", cartId);
                cmd.Parameters.AddWithValue("@urunId", urunId);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
        }


        // Yemek miktarını güncelle
        public static bool UpdateMealQuantity(int cartId, int urunId, int newQuantity)
        {
            try
            {
                Connection conn = new Connection();
                using (var cmd = new SqlCommand("cart_UpdateMealQuantity", conn.Connect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    cmd.Parameters.AddWithValue("@urunId", urunId);
                    cmd.Parameters.AddWithValue("@quantity", newQuantity);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adet güncellenirken hata: " + ex.Message);
                return false;
            }
        }

    }
}
