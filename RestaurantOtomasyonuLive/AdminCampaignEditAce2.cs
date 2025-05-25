using RestaurantOtomasyonuLive.RestaurantOtomasyonuLive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class AdminCampaignEditAce2 : Form
    {
        public AdminCampaignEditAce2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Bir resim seçiniz";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName;

                string hedefKlasor = Path.Combine(Application.StartupPath, "Resources");

                if (!Directory.Exists(hedefKlasor))
                {
                    Directory.CreateDirectory(hedefKlasor);
                }

                string hedefDosyaYolu = Path.Combine(hedefKlasor, Path.GetFileName(secilenDosyaYolu));

                File.Copy(secilenDosyaYolu, hedefDosyaYolu, true);

                pictureBox1.Image = Image.FromFile(hedefDosyaYolu);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                // Dosya yolunu PictureBox'ın Tag'ına kaydet
                pictureBox1.Tag = hedefDosyaYolu;

                MessageBox.Show("Resim başarıyla kopyalandı: " + hedefDosyaYolu);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string head = txt_campaignHead.Text.Trim();
            string description = txt_campaignText.Text.Trim();
            string imagePath = pictureBox1.Tag as string;

            if (string.IsNullOrEmpty(head) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve bir resim seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CampaignSQLAce campaignSQL = new CampaignSQLAce();

            bool isAdded = campaignSQL.addCampaign(head, description, imagePath);

            if (isAdded)
            {
                MessageBox.Show("Kampanya başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_campaignHead.Clear();
                txt_campaignText.Clear();
                pictureBox1.Image = null;
                pictureBox1.Tag = null;
            }
            else
            {
                MessageBox.Show("Kampanya eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}