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
    public partial class AdminMessagesForm : Form
    {
        public AdminMessagesForm()
        {
            InitializeComponent();
        }

        private void AdminMessagesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlMethods4Ace.GetMessages();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["message_id"].Value);
                DataRow detail = sqlMethods4Ace.GetMessageDetail(selectedId);
                if (detail != null)
                {
                    lbl_mail.Text = detail["mail"].ToString();
                    lbl_topic.Text = detail["subject"].ToString();
                    rtxt_message.Text = detail["message_body"].ToString();
                }
            }
        }
    }
}
