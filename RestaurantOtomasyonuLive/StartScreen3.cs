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
    public partial class StartScreen3 : Form
    {
        Notification notification = new Notification();
        public StartScreen3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // Boş bırakma kontrolü
            if (string.IsNullOrWhiteSpace(txt_mail.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                notification.showNotification(this, "Mail ve şifre boş bırakılamaz!", true);
                return;
            }

            // Giriş işlemi
            if (sqlMethods3.login(txt_mail.Text, txt_password.Text))  // login metodu burada başarılıysa
            {
                // Kullanıcı bilgilerini al
                KullaniciGiris(txt_mail.Text, txt_password.Text);

                notification.showNotification(this, "Hoş geldiniz!", false);
                MainMenu3 mainMenu2 = new MainMenu3();
                mainMenu2.Show();
                this.Hide();
            }
            else // Hatalı giriş işlemi, var olmayan kullanıcı bilgileri
            {
                notification.showNotification(this, "Hatalı mail ya da şifre!", true);
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUpScreen signUpScreen = new SignUpScreen();
            signUpScreen.Show();
            this.Hide();
        }

        private void btn_loginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public class Kullanici
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Telefon { get; set; }
            public string Mail { get; set; }
            public string Sifre { get; set; }
        }

        public static class KullaniciBilgileri
        {
            public static Kullanici KullaniciData { get; set; }
        }

        //kullanıcı giriş yaptığı zaman bilgileri buraya çekiyoruz kullanmak için, üstteki kullanıcı sınıfında tutuluyor
        public void KullaniciGiris(string email, string sifre)
        {
            Connection conn = new Connection();

            using (SqlCommand cmd = new SqlCommand("sp_KullaniciGiris", conn.Connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@psswrd", sifre);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        KullaniciBilgileri.KullaniciData = new Kullanici
                        {
                            Ad = reader["Ad"].ToString(),
                            Soyad = reader["Soyad"].ToString(),
                            Telefon = reader["Telefon"].ToString(),
                            Mail = reader["Mail"].ToString(),
                            Sifre = reader["psswrd"].ToString()
                        };
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı veya şifre hatalı.");
                    }
                }
            }
        }
    }
}
