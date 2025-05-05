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

namespace RestaurantOtomasyonuLive
{
    public partial class AdminCampaignEdit : Form
    {
        public AdminCampaignEdit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // sadece resim dosyaları göster
            openFileDialog.Title = "Bir resim seçiniz";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName; // seçilen dosyanın tam yolu
                string hedefKlasor = Path.Combine(Application.StartupPath, "Resources"); // uygulamanın içindeki uploads klasörü

                string hedefDosyaYolu = Path.Combine(hedefKlasor, Path.GetFileName(secilenDosyaYolu)); // hedef dosya yolu

                File.Copy(secilenDosyaYolu, hedefDosyaYolu, true); // dosyayı kopyala, true = aynı isimde varsa üstüne yaz

                pictureBox1.Image = Image.FromFile(hedefDosyaYolu);
                MessageBox.Show("Resim başarıyla kopyalandı: " + hedefDosyaYolu);

                //buradaki dosya yolunu veri tabanına kaydetmek gerekecek, aynı zamanda dosyanın adı da gerekecektir
            }
        }
    }
}
