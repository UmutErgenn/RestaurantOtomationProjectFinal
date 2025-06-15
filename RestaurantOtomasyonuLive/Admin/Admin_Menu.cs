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
using static RestaurantOtomasyonuLive.sqlMethods;

namespace RestaurantOtomasyonuLive
{
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string gorselYolu = "";

        private void add_Image(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Bir resim seçiniz"
            };

            string hedefKlasor = Path.Combine(Application.StartupPath, "Resources");

            if (!Directory.Exists(hedefKlasor))
            {
                Directory.CreateDirectory(hedefKlasor);
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName;
                string hedefDosyaYolu = Path.Combine(hedefKlasor, Path.GetFileName(secilenDosyaYolu));

                try
                {
                    File.Copy(secilenDosyaYolu, hedefDosyaYolu, true);
                    urun_resim.Image = Image.FromFile(hedefDosyaYolu);
                    gorselYolu = hedefDosyaYolu;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Resim kopyalanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gorselYolu = "";
                }
            }
        }

        private void save()
        {
            string urunAdi = urun_ad.Text.Trim();
            string urunAciklama = urun_detay.Text.Trim();
            string urunFiyatStr = fiyat.Text.Trim();

            if (string.IsNullOrWhiteSpace(urunAdi) || string.IsNullOrWhiteSpace(gorselYolu)
                || string.IsNullOrWhiteSpace(urunAciklama) || string.IsNullOrWhiteSpace(urunFiyatStr))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(urunFiyatStr, out decimal urunFiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Geçersiz Fiyat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ComboBox'dan kategori ID al
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.", "Kategori Seçimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int secilenKategoriId = comboBox1.SelectedIndex + 1;

            sqlMethods sql = new sqlMethods();
            bool basarili = sql.UrunEkle(urunAdi, gorselYolu, urunAciklama, urunFiyat, secilenKategoriId);

            if (basarili)
            {
                MessageBox.Show("Ürün başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Ürün eklenirken hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            urun_ad.Text = "";
            urun_detay.Text = "";
            fiyat.Text = "";
            urun_resim.Image = null;
            gorselYolu = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void urun_detay_TextChanged(object sender, EventArgs e)
        {
            // Gerekirse buraya kod ekleyebilirsiniz
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {

        }
    }
}