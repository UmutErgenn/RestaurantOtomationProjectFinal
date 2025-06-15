using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class OrderDetailsForm : Form
    {
        private readonly int _orderId;

        public OrderDetailsForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            
            this.Text = $"Sipariş {_orderId} Detayları";
            LoadDetails();
        }


        private void LoadDetails()
        {
            using (SqlConnection conn = new Connection().Connect)
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                    SELECT 
                      u.UrunAdi               AS [Ürün],
                      od.quantity             AS [Adet],
                      od.unit_price           AS [Birim Fiyat],
                      od.quantity * od.unit_price AS [Tutar]
                    FROM OrderDetails od
                    JOIN Urunler u ON od.urun_id = u.urun_id
                    WHERE od.order_id = @oid";
                cmd.Parameters.AddWithValue("@oid", _orderId);

                var dt = new DataTable();
                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(dt);

                dataGridViewDetails.DataSource = dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
