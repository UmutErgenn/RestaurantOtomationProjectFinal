using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_signUpPerson_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kayıt Eklensin Mi?", "Kayıt Ekleme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    sqlMethods.SignUp(txt_nameSignUp.Text, txt_surnameSignUp.Text, txt_mailSignUp.Text, txt_passwordSignUp.Text, txt_phoneNumSignUp.Text,combobox_genderSignUp.Text);
                    MessageBox.Show("Kayıt Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata: " + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kayıt İptal Edildi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_cancelSignUpForm_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void btn_signUpExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
