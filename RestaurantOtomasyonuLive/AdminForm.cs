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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void btn_Campaigns_Click(object sender, EventArgs e)
        {
            AdminCampaign adminCampaign = new AdminCampaign();
            adminCampaign.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AdminMessages_Click(object sender, EventArgs e)
        {
            AdminMessagesForm adminMessagesForm = new AdminMessagesForm();
            adminMessagesForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StockUserControl stockUC = new StockUserControl();
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


    }
}
