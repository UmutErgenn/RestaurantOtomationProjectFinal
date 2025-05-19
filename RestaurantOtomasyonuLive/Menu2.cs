using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
            UrunleriYukle();
        }

        private void UrunleriYukle()
        {
            flowLayoutMainPanel.Controls.Clear();

            sqlMethods4 sql = new sqlMethods4();
            var urunler = sql.UrunleriGetir(); // Artık: (int Id, string UrunAdi, string GorselYolu, string UrunDescription)

            foreach (var (id, urunAdi, gorselYolu, urunDescription, urun_fiyat) in urunler)
            {
                Panel urunPanel = new Panel
                {
                    Width = 140,
                    Height = 165,
                    Margin = new Padding(10),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = id  // Gerekirse ID'yi panelde tut
                };

                Label lblUrunAdi = new Label
                {
                    Text = urunAdi,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Height = 30,
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblAltBaslik = new Label
                {
                    Text = urun_fiyat + "TL",
                    Dock = DockStyle.Bottom,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Height = 20,
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox pb = new PictureBox
                {
                    Dock = DockStyle.Top,
                    Height = 115,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = gorselYolu,
                    Cursor = Cursors.Hand
                };

                // Tıklama olayında tüm bilgileri ilet (örneğin açıklamayı da göster)
                pb.Click += (sender, e) => PanelTiklandi(sender, e, urunAdi, urunDescription, gorselYolu, urun_fiyat);



                // Eklenme sırasına dikkat: Bottom -> Fill -> Top
                urunPanel.Controls.Add(lblAltBaslik);
                urunPanel.Controls.Add(pb);
                urunPanel.Controls.Add(lblUrunAdi);

                flowLayoutMainPanel.Controls.Add(urunPanel);
            }

            int urunSayisi = flowLayoutMainPanel.Controls.Count;
            int satirSayisi = (int)Math.Ceiling(urunSayisi / 4.0);
            flowLayoutMainPanel.Height = satirSayisi * 200;
        }


        private void PanelTiklandi(object sender, EventArgs e, String urunAdi, String urunDescription, String gorselYolu, String urun_fiyat)
        {
            flowLayoutPanelEx.Visible = true;
            urun_name.Text = urunAdi;
            urun_desc.Text = urunDescription;
            urun_resim.Image = Image.FromFile(gorselYolu);
            label_fiyat.Text = "Ürün Fiyatı: " + urun_fiyat + "TL";
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanelEx.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanelEx.Visible = false;
            Notification notification = new Notification();
            notification.showNotification(this, "Ürün sepete eklendi", false);
        }
    }
}
