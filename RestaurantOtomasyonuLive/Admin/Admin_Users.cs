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
    public partial class Admin_Users : Form
    {
        public Admin_Users()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sqlMethods.getAllPersons();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            StilizeDataGridView();
        }

        private void LoadUsers()
        {
            
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

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                var confirmResult = MessageBox.Show("Bu kullanıcıyı silmek istediğinizden emin misiniz?",
                                                     "Onay",
                                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = sqlMethods.deleteUser(selectedId);
                    if (success)
                    {
                        MessageBox.Show("Kullanıcı silindi.");
                        // Listeyi yenile
                        Users_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir kullanıcı seçin.");
            }
        }

        private void StilizeDataGridView()
        {
            // Genel Ayarlar
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(44, 44, 44);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowHeadersVisible = false;

            // Başlık (Header) Ayarları
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            // Gridline ve diğer
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void btn_Users_Click(object sender, EventArgs e)
        {

        }
    }
}
