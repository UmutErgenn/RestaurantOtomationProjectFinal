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
    public partial class Admin_MainMenu : Form
    {
        public Admin_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Admin_Users users = new Admin_Users();
            users.Show();
            this.Hide();
        }

        private void btn_Campaigns_Click(object sender, EventArgs e)
        {
            Admin_Campaign adminCampaign = new Admin_Campaign();
            adminCampaign.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AdminMessages_Click(object sender, EventArgs e)
        {
            Admin_Messages adminMessagesForm = new Admin_Messages();
            adminMessagesForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Admin_StockControl stockUC = new Admin_StockControl();
            panel1.Controls.Add(stockUC);
            stockUC.Dock = DockStyle.Fill;
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StatisticsUserControl statUC = new StatisticsUserControl();
            panel1.Controls.Add(statUC);
            statUC.Dock = DockStyle.Fill;
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            // Önce paneli temizle
            panel1.Controls.Clear();

            // MenuAdminAce formunu bir child form olarak oluştur
            Admin_Menu menusForm = new Admin_Menu
            {
                TopLevel = false,                   // child form yap
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            // panel1 içine ekle ve göster
            panel1.Controls.Add(menusForm);
            menusForm.Show();
        }


        private void btn_Orders_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var ordersUC = new OrdersUserControl { Dock = DockStyle.Fill };
            panel1.Controls.Add(ordersUC);
        }

        private void btn_Staffs_Click(object sender, EventArgs e)
        {
            Admin_Personel admin_Personel = new Admin_Personel();
            admin_Personel.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Close();
        }
    }
}
