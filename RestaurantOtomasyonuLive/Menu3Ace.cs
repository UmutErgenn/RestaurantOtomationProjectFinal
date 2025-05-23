﻿using System;
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
    public partial class Menu3Ace : Form
    {
        private int kategoriId;

        public Menu3Ace(int kategoriId)
        {
            InitializeComponent();
            this.kategoriId = kategoriId;
            UrunleriYukle(kategoriId);
        }

        private void UrunleriYukle(int kategoriId)
        {
            flowLayoutMainPanel.Controls.Clear();

            sqlMethods4Ace sql = new sqlMethods4Ace();
            var urunler = sql.UrunleriGetir(kategoriId);

            foreach (var (id, urunAdi, gorselYolu, urunDescription, urun_fiyat) in urunler)
            {
                Panel urunPanel = new Panel
                {
                    Width = 140,
                    Height = 165,
                    Margin = new Padding(10),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = id // Ürün id'si
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
                    Text = urun_fiyat + " TL",
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

                pb.Click += (sender, e) => PanelTiklandi(sender, e, urunAdi, urunDescription, gorselYolu, urun_fiyat.ToString());

                urunPanel.Controls.Add(lblAltBaslik);
                urunPanel.Controls.Add(pb);
                urunPanel.Controls.Add(lblUrunAdi);

                flowLayoutMainPanel.Controls.Add(urunPanel);
            }

            int urunSayisi = flowLayoutMainPanel.Controls.Count;
            int satirSayisi = (int)Math.Ceiling(urunSayisi / 4.0);
            flowLayoutMainPanel.Height = satirSayisi * 200;
        }

        private void PanelTiklandi(object sender, EventArgs e, string urunAdi, string urunDescription, string gorselYolu, string urun_fiyat)
        {
            flowLayoutPanelEx.Visible = true;
            urun_name.Text = urunAdi;
            urun_desc.Text = urunDescription;

            try
            {
                urun_resim.Image = Image.FromFile(gorselYolu);
            }
            catch
            {
                urun_resim.Image = null; // Resim yüklenemezse boş bırak
            }

            label_fiyat.Text = "Ürün Fiyatı: " + urun_fiyat + " TL";
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

            // Sepete ekleme işlemi için kod buraya
            try
            {
                bool ok = sqlMethods4Ace.AddMealToCart(
                    AppSession.CartId,
                    urun_name.Text,
                    Convert.ToInt32(urun_quantity.Value)
                );
                notification.showNotification(this, "Ürün sepete eklendi", false);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Eğer gerekli değilse kaldırabilirsiniz
        }

        private void urun_quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            CardForm form = new CardForm();
            this.Hide();
            form.Show();
        }
    }
}