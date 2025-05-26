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
            if (sqlMethods4Ace2.login(txt_mail.Text, txt_password.Text))  // login metodu burada başarılıysa
            {
                // Kullanıcı bilgilerini al
                KullaniciGiris(txt_mail.Text, txt_password.Text);

                notification.showNotification(this, "Hoş geldiniz!", false);
                // Kullanıcı rolüne göre yönlendirme yapılıyor. TODO: buraya daha sonra personel de eklenecek
                string role = KullaniciBilgileri.KullaniciData.Role;
                if (role.Equals("admin"))
                {
                    AdminFormAce3 adminForm = new AdminFormAce3();
                    adminForm.Show();
                    this.Hide();
                }
                else if (role.Equals("user"))
                {
                    User_MainMenu mainMenu2 = new User_MainMenu();
                    mainMenu2.Show();
                    this.Hide();
                }
                else if (role.Equals("personel"))
                {
                    // Pozisyonu da gönder
                    string pozisyon = KullaniciBilgileri.KullaniciData.Role; // Eğer pozisyon ayrı bir alan ise, ona göre değiştirin
                    string position = ""; // Pozisyonu çekmek için ek alan
                    // Pozisyonu veritabanından çekmek için:
                    using (SqlCommand cmd = new SqlCommand("SELECT e.e_position FROM person p JOIN employee e ON p.person_id = e.p_id_FK WHERE p.mail = @mail", new Connection2().Connect))
                    {
                        cmd.Parameters.AddWithValue("@mail", KullaniciBilgileri.KullaniciData.Mail);
                        var pos = cmd.ExecuteScalar();
                        if (pos != null)
                            position = pos.ToString();
                    }
                    StaffForm staffForm = new StaffForm(position); // Pozisyonu parametre olarak gönder
                    staffForm.Show();
                    this.Hide();
                }
                //currentCartId = sqlMethods4.CreateCart(StartScreen3.KullaniciBilgileri.KullaniciData.Mail);
                AppSession.CartId = sqlMethods4Ace2.GetOrCreateCart(KullaniciBilgileri.KullaniciData.Mail);
            }
            else // Hatalı giriş işlemi, var olmayan kullanıcı bilgileri
            {
                notification.showNotification(this, "Hatalı mail ya da şifre!", true);
            }
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            SignUpScreenAce2 signUpScreen = new SignUpScreenAce2();
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
            public string Role { get; set; }
        }

        public static class KullaniciBilgileri
        {
            public static Kullanici KullaniciData { get; set; }
        }

        //kullanıcı giriş yaptığı zaman bilgileri buraya çekiyoruz kullanmak için, üstteki kullanıcı sınıfında tutuluyor
        public void KullaniciGiris(string email, string sifre)
        {
            Connection2 conn = new Connection2();

            using (SqlCommand cmd = new SqlCommand("sp_KullaniciGiris", conn.Connect))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@mail", email);
                cmd.Parameters.AddWithValue("@psswrd", sifre);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        KullaniciBilgileri.KullaniciData = new Kullanici
                        {
                            Ad = reader["Ad"].ToString(),
                            Soyad = reader["Soyad"].ToString(),
                            Telefon = reader["Telefon"].ToString(),
                            Mail = reader["Mail"].ToString(),
                            Sifre = reader["psswrd"].ToString(),
                            Role = role
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
