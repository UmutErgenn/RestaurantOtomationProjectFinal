using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestaurantOtomasyonuLive.sqlMethods4;

namespace RestaurantOtomasyonuLive
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string gorselYolu;
        private void add_Image(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // sadece resim dosyaları göster
            openFileDialog.Title = "Bir resim seçiniz";

            string hedefKlasor = Path.Combine(Application.StartupPath, "Resources");

            if (!Directory.Exists(hedefKlasor))
            {
                Directory.CreateDirectory(hedefKlasor);
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName;
                string hedefDosyaYolu = Path.Combine(hedefKlasor, Path.GetFileName(secilenDosyaYolu));

                File.Copy(secilenDosyaYolu, hedefDosyaYolu, true);

                urun_resim.Image = Image.FromFile(hedefDosyaYolu);

                gorselYolu = hedefDosyaYolu; // burası önemli, gorselYolu değişkenini güncelle!
            }
        }

        private void save()
        {
            string urunFiyat = fiyat.Text.Trim();
            string urunAdi = urun_ad.Text.Trim();
            string urunAciklama = urun_detay.Text.Trim();

            if (string.IsNullOrWhiteSpace(urunAdi) || string.IsNullOrWhiteSpace(gorselYolu) || string.IsNullOrWhiteSpace(urunAciklama) || string.IsNullOrWhiteSpace(urunFiyat))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sqlMethods4 sql = new sqlMethods4();
            bool basarili = sql.UrunEkle(urunAdi, gorselYolu, urunAciklama, urunFiyat);

            if (basarili)
            {
                MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ürün eklenirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void urun_detay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
