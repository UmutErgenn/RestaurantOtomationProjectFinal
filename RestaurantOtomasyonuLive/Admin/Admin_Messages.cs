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
    public partial class Admin_Messages : Form
    {
        public Admin_Messages()
        {
            InitializeComponent();
        }

        private void AdminMessagesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlMethods.GetMessages();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["message_id"].Value);
                DataRow detail = sqlMethods.GetMessageDetail(selectedId);
                if (detail != null)
                {
                    lbl_mail.Text = detail["mail"].ToString();
                    lbl_topic.Text = detail["subject"].ToString();
                    rtxt_message.Text = detail["message_body"].ToString();
                }
            }
        }

        private void btn_Menus_Click(object sender, EventArgs e)
        {
            Admin_Menu adminMenu = new Admin_Menu();
            adminMenu.Show();
            this.Hide();
        }

        private void btn_Campaigns_Click(object sender, EventArgs e)
        {
            Admin_Campaign adminCampaign = new Admin_Campaign();
            adminCampaign.Show();
            this.Hide();
        }

        private void btn_Staffs_Click(object sender, EventArgs e)
        {
            Admin_Personel admin_Personel = new Admin_Personel();
            admin_Personel.Show();
            this.Hide();
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
            Admin_Users admin_Users = new Admin_Users();
            admin_Users.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Close();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            
        }
    }
}
