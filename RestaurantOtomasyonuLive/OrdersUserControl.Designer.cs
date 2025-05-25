using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    partial class OrdersUserControl
    {
        private IContainer components = null;
        private TableLayoutPanel tableLayoutMain;
        private Panel panelFilter;
        private Label lblStart;
        private DateTimePicker dtpStart;
        private Label lblEnd;
        private DateTimePicker dtpEnd;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnApply;
        private Button btnRefresh;
        private SplitContainer splitContainer;
        private DataGridView dgvOrders;
        private DataGridView dgvOrderDetails;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();
            this.tableLayoutMain = new TableLayoutPanel();
            this.panelFilter = new Panel();
            this.lblStart = new Label();
            this.dtpStart = new DateTimePicker();
            this.lblEnd = new Label();
            this.dtpEnd = new DateTimePicker();
            this.lblSearch = new Label();
            this.txtSearch = new TextBox();
            this.btnApply = new Button();
            this.btnRefresh = new Button();
            this.splitContainer = new SplitContainer();
            this.dgvOrders = new DataGridView();
            this.dgvOrderDetails = new DataGridView();

            // tableLayoutMain
            this.tableLayoutMain.ColumnCount = 1;
            this.tableLayoutMain.RowCount = 2;
            this.tableLayoutMain.Dock = DockStyle.Fill;
            this.tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(this.tableLayoutMain);

            // panelFilter
            this.panelFilter.BackColor = Color.FromArgb(45, 45, 48);
            this.panelFilter.Dock = DockStyle.Top;
            this.panelFilter.Height = 40;
            this.panelFilter.Padding = new Padding(5);

            // lblStart
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new Point(5, 10);
            this.lblStart.Text = "Başlangıç:";
            this.lblStart.ForeColor = Color.White;

            // dtpStart
            this.dtpStart.Format = DateTimePickerFormat.Short;
            this.dtpStart.Location = new Point(75, 7);
            this.dtpStart.Width = 100;

            // lblEnd
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new Point(185, 10);
            this.lblEnd.Text = "Bitiş:";
            this.lblEnd.ForeColor = Color.White;

            // dtpEnd
            this.dtpEnd.Format = DateTimePickerFormat.Short;
            this.dtpEnd.Location = new Point(225, 7);
            this.dtpEnd.Width = 100;

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new Point(335, 10);
            this.lblSearch.Text = "Ara:";
            this.lblSearch.ForeColor = Color.White;

            // txtSearch
            this.txtSearch.Location = new Point(370, 7);
            this.txtSearch.Width = 120;

            // btnApply
            this.btnApply.Text = "Uygula";
            this.btnApply.Location = new Point(500, 5);
            this.btnApply.Width = 70;
            this.btnApply.FlatStyle = FlatStyle.Flat;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.ForeColor = Color.LightGray;
            this.btnApply.MouseEnter += (s, e) => btnApply.ForeColor = Color.White;
            this.btnApply.MouseLeave += (s, e) => btnApply.ForeColor = Color.LightGray;
            this.btnApply.Click += new EventHandler(this.btnApply_Click);

            // btnRefresh
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Location = new Point(580, 5);
            this.btnRefresh.Width = 70;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.ForeColor = Color.LightGray;
            this.btnRefresh.MouseEnter += (s, e) => btnRefresh.ForeColor = Color.White;
            this.btnRefresh.MouseLeave += (s, e) => btnRefresh.ForeColor = Color.LightGray;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);

            this.panelFilter.Controls.AddRange(new Control[] {
                this.lblStart, this.dtpStart,
                this.lblEnd,   this.dtpEnd,
                this.lblSearch,this.txtSearch,
                this.btnApply, this.btnRefresh
            });
            this.tableLayoutMain.Controls.Add(this.panelFilter, 0, 0);

            // splitContainer
            this.splitContainer.Dock = DockStyle.Fill;
            this.splitContainer.Orientation = Orientation.Horizontal;
            this.splitContainer.SplitterWidth = 4;
            this.splitContainer.FixedPanel = FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Panel1MinSize = 200;
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.Panel1.BackColor = Color.FromArgb(30, 30, 30);
            this.tableLayoutMain.Controls.Add(this.splitContainer, 0, 1);

            // dgvOrders
            var dgHead = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(28, 28, 28),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                SelectionBackColor = Color.FromArgb(0, 122, 204),
                SelectionForeColor = Color.White
            };
            this.dgvOrders.Dock = DockStyle.Fill;
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dgHead;
            this.dgvOrders.BackgroundColor = Color.FromArgb(30, 30, 30);
            this.dgvOrders.GridColor = Color.FromArgb(45, 45, 48);
            this.dgvOrders.ForeColor = Color.White;
            this.dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(37, 37, 38),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(0, 122, 204),
                SelectionForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular)
            };
            this.dgvOrders.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(45, 45, 48)
            };
            this.splitContainer.Panel1.Controls.Add(this.dgvOrders);

            // dgvOrderDetails
            this.dgvOrderDetails.Dock = DockStyle.Fill;
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AllowUserToOrderColumns = false;
            this.dgvOrderDetails.AllowUserToResizeColumns = false;
            this.dgvOrderDetails.AllowUserToResizeRows = false;
            this.dgvOrderDetails.RowHeadersVisible = false;
            this.dgvOrderDetails.EnableHeadersVisualStyles = false;
            this.dgvOrderDetails.ColumnHeadersDefaultCellStyle = dgHead;
            this.dgvOrderDetails.BackgroundColor = Color.FromArgb(30, 30, 30);
            this.dgvOrderDetails.GridColor = Color.FromArgb(45, 45, 48);
            this.dgvOrderDetails.ForeColor = Color.White;
            this.dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderDetails.DefaultCellStyle = this.dgvOrders.DefaultCellStyle;
            this.dgvOrderDetails.AlternatingRowsDefaultCellStyle = this.dgvOrders.AlternatingRowsDefaultCellStyle;
            this.splitContainer.Panel2.Controls.Add(this.dgvOrderDetails);

            // OrdersUserControl
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutMain);
            this.Name = "OrdersUserControl";
            this.Size = new Size(800, 600);
            this.Load += new EventHandler(this.OrdersUserControl_Load);
        }

        #endregion
    }
}
