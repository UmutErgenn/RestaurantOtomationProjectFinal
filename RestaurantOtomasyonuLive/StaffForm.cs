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
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            pnlWaiter.Visible = false;
            pnlKitchen.Visible = false;
            pnlDefault.Visible = true;

            if (_position == "garson")
            {
                pnlWaiter.Visible = true;
                pnlWaiter.BringToFront();
                pnlKitchen.Visible = false;
                pnlDefault.Visible = false;
                LoadWaiterOrders();
            }
            else if (_position == "mutfak")
            {
                pnlKitchen.Visible = true;
                pnlKitchen.BringToFront();
                pnlWaiter.Visible = false;
                pnlDefault.Visible = false;
                LoadKitchenOrders();
            }
        }

        private void btn_Waiter_Click(object sender, EventArgs e)
        {
            pnlWaiter.Visible = true;
            pnlWaiter.BringToFront();
            pnlKitchen.Visible = false;
            pnlDefault.Visible = false;
            LoadWaiterOrders();
        }

        private void btn_Kitchen_Click(object sender, EventArgs e)
        {
            pnlKitchen.Visible = true;
            pnlKitchen.BringToFront();
            pnlWaiter.Visible = false;
            pnlDefault.Visible = false;
            LoadKitchenOrders();
        }

        private void LoadWaiterOrders()
        {
            // Garsonun göreceği siparişleri getir
            dgvWaiterOrders.DataSource = sqlMethods4Ace3.GetWaiterOrders();
        }

        private void LoadKitchenOrders()
        {
            // Mutfak personelinin göreceği siparişleri getir
            dgvKitchenOrders.DataSource = sqlMethods4Ace3.GetKitchenOrders();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            if (dgvWaiterOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvWaiterOrders.SelectedRows[0].Cells["order_id"].Value);
                var detail = sqlMethods4Ace3.GetOrderDetail(orderId);
                MessageBox.Show(detail, "Sipariş Detayı");
            }
        }

        private void btnOrderApprove_Click(object sender, EventArgs e)
        {
            if (dgvWaiterOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvWaiterOrders.SelectedRows[0].Cells["order_id"].Value);
                sqlMethods4Ace3.UpdateOrderStatus(orderId, "Onaylandı");
                LoadWaiterOrders();
            }
        }

        private void btnOrderReject_Click(object sender, EventArgs e)
        {
            if (dgvWaiterOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvWaiterOrders.SelectedRows[0].Cells["order_id"].Value);
                sqlMethods4Ace3.UpdateOrderStatus(orderId, "Reddedildi");
                LoadWaiterOrders();
            }
        }

        private void btn_mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
