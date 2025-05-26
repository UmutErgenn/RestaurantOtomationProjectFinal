using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    partial class OrdersForm
    {
        private IContainer components = null;
        private Panel panelHeader;
        private PictureBox pictureBoxBack;
        private Label lblTitle;
        private Panel panelFilter;
        private Label lblFrom;
        private DateTimePicker dateTimePickerFrom;
        private Label lblTo;
        private DateTimePicker dateTimePickerTo;
        private Button btnFilter;
        private DataGridView dataGridViewOrders;
        private Panel panelButtons;
        private Button btnRefresh;
        private Button btnViewDetails;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new Panel();
            this.pictureBoxBack = new PictureBox();
            this.lblTitle = new Label();
            this.panelFilter = new Panel();
            this.lblFrom = new Label();
            this.dateTimePickerFrom = new DateTimePicker();
            this.lblTo = new Label();
            this.dateTimePickerTo = new DateTimePicker();
            this.btnFilter = new Button();
            this.dataGridViewOrders = new DataGridView();
            this.panelButtons = new Panel();
            this.btnRefresh = new Button();
            this.btnViewDetails = new Button();
            this.btnCancel = new Button();

            ((ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = Color.FromArgb(30, 30, 30);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Controls.Add(this.pictureBoxBack);
            this.panelHeader.Controls.Add(this.lblTitle);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = Cursors.Hand;
            this.pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxBack.Location = new Point(10, 15);
            this.pictureBoxBack.Size = new Size(30, 30);
            this.pictureBoxBack.Click += new EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.Location = new Point(55, 16);
            this.lblTitle.Text = "Siparişlerim";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = Color.WhiteSmoke;
            this.panelFilter.Dock = DockStyle.Top;
            this.panelFilter.Height = 70;
            this.panelFilter.Padding = new Padding(10);
            this.panelFilter.Controls.Add(this.lblFrom);
            this.panelFilter.Controls.Add(this.dateTimePickerFrom);
            this.panelFilter.Controls.Add(this.lblTo);
            this.panelFilter.Controls.Add(this.dateTimePickerTo);
            this.panelFilter.Controls.Add(this.btnFilter);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = Color.FromArgb(60, 60, 60);
            this.lblFrom.Location = new Point(20, 25);
            this.lblFrom.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblFrom.Text = "Başlangıç:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new Point(100, 22);
            this.dateTimePickerFrom.Width = 120;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = Color.FromArgb(60, 60, 60);
            this.lblTo.Location = new Point(240, 25);
            this.lblTo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.lblTo.Text = "Bitiş:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new Point(290, 22);
            this.dateTimePickerTo.Width = 120;
            // 
            // btnFilter
            // 
            this.btnFilter.Text = "Filtrele";
            this.btnFilter.BackColor = Color.FromArgb(179, 34, 42);
            this.btnFilter.ForeColor = Color.White;
            this.btnFilter.FlatStyle = FlatStyle.Flat;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnFilter.Size = new Size(100, 30);
            this.btnFilter.Location = new Point(430, 20);
            this.btnFilter.Click += new EventHandler(this.btnFilter_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.Dock = DockStyle.Fill;
            this.dataGridViewOrders.Location = new Point(0, 130);
            this.dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrders.EnableHeadersVisualStyles = false;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dataGridViewOrders.RowTemplate.Height = 30;
            this.dataGridViewOrders.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            this.dataGridViewOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            // sabit tablo
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.AllowUserToResizeColumns = false;
            this.dataGridViewOrders.AllowUserToOrderColumns = false;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = Color.WhiteSmoke;
            this.panelButtons.Dock = DockStyle.Bottom;
            this.panelButtons.Height = 60;
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Controls.Add(this.btnViewDetails);
            this.panelButtons.Controls.Add(this.btnCancel);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.BackColor = Color.FromArgb(60, 60, 60);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnRefresh.Size = new Size(90, 35);
            this.btnRefresh.Location = new Point(30, 12);
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Text = "Detay Görüntüle";
            this.btnViewDetails.BackColor = Color.FromArgb(179, 34, 42);
            this.btnViewDetails.ForeColor = Color.White;
            this.btnViewDetails.FlatStyle = FlatStyle.Flat;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnViewDetails.Size = new Size(120, 35);
            this.btnViewDetails.Location = new Point(140, 12);
            this.btnViewDetails.Click += new EventHandler(this.btnViewDetails_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "İptal Et";
            this.btnCancel.BackColor = Color.FromArgb(60, 60, 60);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCancel.Size = new Size(90, 35);
            this.btnCancel.Location = new Point(280, 12);
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            // 
            // OrdersForm
            // 
            this.ClientSize = new Size(800, 550);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Load += new EventHandler(this.OrdersForm_Load);

            ((ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
