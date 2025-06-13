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
    public partial class User_MenuHome : Form
    {
        public User_MenuHome()
        {
            InitializeComponent();
        }

        public void LoadFormIntoPanel(Form form)
        {
            PanelMenu.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            PanelMenu.Controls.Add(form);
            form.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new SignUpScreenAce3().Show();
            this.Close();
        }

        private void pBox_AccountLogo_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_MyAccount());
        }

        private void pBox_CartLogo_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new User_CardForm());
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            LoadFormIntoPanel(new User_Menu(clickedIndex));
        }

        private void btn_Ana_Menü_Click_1(object sender, EventArgs e)
        {
            User_MainMenu mainMenu3 = new User_MainMenu();
            this.Hide();
            mainMenu3.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            StartScreen3 startScreen3 = new StartScreen3();
            startScreen3.Show();
        }
    }
}