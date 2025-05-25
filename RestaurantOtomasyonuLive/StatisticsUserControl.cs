using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RestaurantOtomasyonuLive
{
    public partial class StatisticsUserControl : UserControl
    {
        

        public StatisticsUserControl()
        {
            InitializeComponent();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            // Aşağıdaki örneklerde sen kendi veritabanı katmanını kullan!
            // Kodda dummy (örnek) değer var, veritabanıdan alıp atayacaksın.

            // 1) Toplam Satış
            lblTotalSalesValue.Text = GetToplamSatis().ToString("N2") + " ₺";

            // 2) Toplam Ödeme
            lblTotalPaymentValue.Text = GetToplamOdeme().ToString("N2") + " ₺";

            // 3) Müşteri Sayısı
            lblCustomerValue.Text = GetMusteriSayisi().ToString();

            // 4) Personel Sayısı
            lblStaffValue.Text = GetPersonelSayisi().ToString();

            // 5) Rezervasyon Sayısı
            lblReservationValue.Text = GetRezervasyonSayisi().ToString();

            // 6) En Çok Satan Menü
            lblTopMenuValue.Text = GetTopMenu();
        }

        private decimal GetToplamSatis()
        {
            using (var conn = new SqlConnection(Connection2.connString))
            using (var cmd = new SqlCommand("sp_ToplamSatis", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }

        private decimal GetToplamOdeme()
        {
            using (var conn = new SqlConnection(Connection2.connString))
            using (var cmd = new SqlCommand("dbo.sp_ToplamOdeme", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                var result = cmd.ExecuteScalar();
                // DBNull kontrolü
                return (result == null || result == DBNull.Value)
                    ? 0
                    : Convert.ToDecimal(result);
            }
        }


        private int GetMusteriSayisi()
        {
            using (var conn = new SqlConnection(Connection2.connString))
            using (var cmd = new SqlCommand("sp_MusteriSayisi", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int GetPersonelSayisi()
        {
            using (var conn = new SqlConnection(Connection2.connString))
            using (var cmd = new SqlCommand("sp_PersonelSayisi", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private int GetRezervasyonSayisi()
        {
            using (var conn = new SqlConnection(Connection2.connString))
            using (var cmd = new SqlCommand("sp_RezervasyonSayisi", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private string GetTopMenu()
        {
            using (var conn = new SqlConnection(Connection2.connString))
            using (var cmd = new SqlCommand("sp_GetTopMenu", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return reader["UrunAdi"].ToString();
                    else
                        return "-";
                }
            }
        }


        private void panelTopMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
