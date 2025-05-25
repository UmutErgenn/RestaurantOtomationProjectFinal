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
    public partial class MenuAce2 : Form
    {
        public MenuAce2()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new SignUpScreenAce().Show();
            this.Close();
        }

        private void pBox_AccountLogo_Click(object sender, EventArgs e)
        {
            MyAccount myAccount = new MyAccount();
            this.Hide();
            myAccount.Show();
        }

        private void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            CardForm myCartForm = new CardForm();
            this.Hide();
            myCartForm.Show();
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ana_Menü_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox == null)
                return;

            int clickedIndex = 1;

            if (clickedPictureBox.Tag != null)
            {
                clickedIndex = Convert.ToInt32(clickedPictureBox.Tag);
            }
            Menu3Ace menu2 = new Menu3Ace(clickedIndex);
            this.Hide();
            menu2.Show();

        }

        private void btn_Ana_Menü_Click_1(object sender, EventArgs e)
        {
            MainMenu3Ace mainMenu3 = new MainMenu3Ace();
            this.Hide();
            mainMenu3.Show();
        }

        private void btn_Menü_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Show();
        }

        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
            ReservationForm form = new ReservationForm();
            this.Hide();
            form.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen3 startScreen3 = new StartScreen3();
            startScreen3.Show();
        }
    }
}