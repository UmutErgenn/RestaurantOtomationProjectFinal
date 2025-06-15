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
    public partial class StaffForm : Form
    {
        private string _position;

        public StaffForm(string position)
        {
            InitializeComponent();
            _position = position?.ToLower();
            //pnlWaiter.Visible = true;
            //pnlKitchen.Visible = true;
            //pnlDefault.Visible = true;
            //dgvWaiterOrders.Visible = true;
            //dgvKitchenOrders.Visible = true;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            if (_position == "garson")
            {
                pnlWaiter.Visible = true;
                dgvWaiterOrders.Visible = true;
                dgvWaiterOrders.BringToFront();
                dgvWaiterOrders.BringToFront();
                dgvWaiterOrders.BringToFront();
                pnlWaiter.BringToFront();
                pnlWaiter.BringToFront();
                pnlWaiter.BringToFront();
                pnlKitchen.Visible = false;
                pnlDefault.Visible = false;
                dgvKitchenOrders.Visible = false;
                LoadWaiterOrders();
            }
            else if (_position == "mutfak")
            {
                pnlKitchen.Visible = true;
                dgvKitchenOrders.Visible = true;
                dgvKitchenOrders.BringToFront();
                pnlKitchen.BringToFront();
                pnlKitchen.BringToFront();
                pnlKitchen.BringToFront();
                pnlWaiter.Visible = false;
                pnlDefault.Visible = false;
                dgvWaiterOrders.Visible = false;
                LoadKitchenOrders();
            }
        }

        private void btn_Waiter_Click(object sender, EventArgs e)
        {
            pnlWaiter.Visible = true;
            dgvWaiterOrders.Visible = true;
            pnlWaiter.BringToFront();
            pnlWaiter.BringToFront();
            pnlWaiter.BringToFront();
            pnlKitchen.Visible = false;
            pnlDefault.Visible = false;
            dgvKitchenOrders.Visible = false;
            LoadWaiterOrders();
        }

        private void btn_Kitchen_Click(object sender, EventArgs e)
        {
            pnlKitchen.Visible = true;
            dgvKitchenOrders.Visible = true;
            pnlKitchen.BringToFront();
            pnlKitchen.BringToFront();
            pnlKitchen.BringToFront();
            pnlWaiter.Visible = false;
            pnlDefault.Visible = false;
            dgvWaiterOrders.Visible = false;
            LoadKitchenOrders();
        }

        private void LoadWaiterOrders()
        {
            // Garsonun göreceği siparişleri getir
            dgvWaiterOrders.DataSource = sqlMethods.GetWaiterOrders();
        }

        private void LoadKitchenOrders()
        {
            // Mutfak personelinin göreceği siparişleri getir
            dgvKitchenOrders.DataSource = sqlMethods.GetKitchenOrders();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvWaiterOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvWaiterOrders.SelectedRows[0].Cells["order_id"].Value);
                var detail = sqlMethods.GetOrderDetail(orderId);
                MessageBox.Show(detail, "Sipariş Detayı");
            }
        }

        private void btnOrderApprove_Click(object sender, EventArgs e)
        {
            if (dgvWaiterOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvWaiterOrders.SelectedRows[0].Cells["order_id"].Value);
                sqlMethods.UpdateOrderStatus(orderId, "Onaylandı");
                LoadWaiterOrders();
            }
        }

        private void btnOrderReject_Click(object sender, EventArgs e)
        {
            if (dgvWaiterOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvWaiterOrders.SelectedRows[0].Cells["order_id"].Value);
                sqlMethods.UpdateOrderStatus(orderId, "Reddedildi");
                LoadWaiterOrders();
            }
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new SignUpScreen().Show();
            this.Close();
        }

        private void btn_kitchenOrderDetails_Click(object sender, EventArgs e)
        {
            if (dgvKitchenOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvKitchenOrders.SelectedRows[0].Cells["order_id"].Value);
                var dt = sqlMethods.GetOrderDetailsKitchen(orderId);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bu siparişe ait ürün detayı bulunamadı.");
                    return;
                }

                StringBuilder sb = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendLine($"{row["Ürün"]} - Adet: {row["Adet"]}");
                }
                MessageBox.Show(sb.ToString(), "Sipariş Ürün Detayları");
            }
        }
    }
}
