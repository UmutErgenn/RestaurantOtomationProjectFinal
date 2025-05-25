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
using static RestaurantOtomasyonuLive.StartScreen3;

namespace RestaurantOtomasyonuLive
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SignUpScreenAce signUpScreen = new SignUpScreenAce();
            signUpScreen.Show();
            this.Close();
        }

        private void btn_Ana_Menü_Click(object sender, EventArgs e)
        {
            MainMenu3Ace mainMenu = new MainMenu3Ace();
            mainMenu.Show();
            this.Close();
        }


        private void Form1_Load()
        {
            if (KullaniciBilgileri.KullaniciData != null)
            {
                // Kullanıcı bilgilerini label'lara yaz
                textBox_adText.Text = KullaniciBilgileri.KullaniciData.Ad;
                textBox_soyadText.Text = KullaniciBilgileri.KullaniciData.Soyad;
                textBox_telefonText.Text = KullaniciBilgileri.KullaniciData.Telefon;
                label_mailText.Text = KullaniciBilgileri.KullaniciData.Mail;
                textBox_şifreText.Text = KullaniciBilgileri.KullaniciData.Sifre;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yüklenemedi.");
            }
        }

        private void btn_SaveChances_Click(object sender, EventArgs e)
        {
            var k = KullaniciBilgileri.KullaniciData;

            if (k == null)
            {
                MessageBox.Show("Kullanıcı bilgileri yüklü değil.");
                return;
            }

            bool bilgiDegisti =
                textBox_adText.Text != k.Ad ||
                textBox_soyadText.Text != k.Soyad ||
                textBox_telefonText.Text != k.Telefon ||
                textBox_şifreText.Text != k.Sifre;

            if (!bilgiDegisti)
            {
                MessageBox.Show("Herhangi bir değişiklik yapılmadı.");
                return;
            }

            // Kullanıcıya onay sorusu
            DialogResult sonuc = MessageBox.Show(
                "Bilgileri güncellemek istediğinizden emin misiniz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                bool guncellendi = sqlMethods4Ace2.UpdateUserInfo(
                    k.Mail,
                    textBox_adText.Text,
                    textBox_soyadText.Text,
                    textBox_telefonText.Text,
                    textBox_şifreText.Text);

                if (guncellendi)
                {
                    MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.");

                    // Bellekteki kullanıcı bilgilerini de güncelle
                    k.Ad = textBox_adText.Text;
                    k.Soyad = textBox_soyadText.Text;
                    k.Telefon = textBox_telefonText.Text;
                    k.Sifre = textBox_şifreText.Text;
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında bir hata oluştu.");
                }
            }
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            var k = KullaniciBilgileri.KullaniciData;

            if (k == null)
            {
                MessageBox.Show("Kullanıcı bilgileri yüklü değil.");
                return;
            }

            // Kullanıcıdan silme işlemini onaylamasını iste
            DialogResult sonuc = MessageBox.Show(
                "Hesabınızı silmek istediğinizden emin misiniz?",
                "Hesap Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new Connection2().Connect)
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_KullaniciSil", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Kullanıcının mail adresini parametre olarak gönder
                            cmd.Parameters.AddWithValue("@mail", k.Mail);

                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Hesap başarıyla silindi.");
                                // Bellekten kullanıcıyı temizle
                                KullaniciBilgileri.KullaniciData = null;
                                StartScreen3 startScreen2 = new StartScreen3();
                                startScreen2.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Hesap silme işlemi sırasında bir hata oluştu.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
