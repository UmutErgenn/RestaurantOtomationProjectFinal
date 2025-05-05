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
    public partial class MainMenu2Campaign : Form
    {
        public MainMenu2Campaign()
        {
            InitializeComponent();
            this.Deactivate += Test1AltCapmaign_Deactivate;
        }

        public void Test1AltCapmaign_Deactivate(object sender, EventArgs e)
        {
            this.Close(); // Form arka plana atılırsa kendiliğinden kapanır
        }

        public void SetCampaignDetails(string title, string description, string imagePath)
        {
            label1.Text = title;
            label2.Text = description;
            pictureBox1.ImageLocation = imagePath;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
