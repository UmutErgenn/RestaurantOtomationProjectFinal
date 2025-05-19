namespace RestaurantOtomasyonuLive
{
    partial class StatisticsUserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel mainPanel;

        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Label lblTopMenuTitle;
        public System.Windows.Forms.Label lblTopMenuValue;

        private System.Windows.Forms.Panel panelTotalSales;
        private System.Windows.Forms.Label lblTotalSalesTitle;
        public System.Windows.Forms.Label lblTotalSalesValue;

        private System.Windows.Forms.Panel panelTotalPayment;
        private System.Windows.Forms.Label lblTotalPaymentTitle;
        public System.Windows.Forms.Label lblTotalPaymentValue;

        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Label lblCustomerTitle;
        public System.Windows.Forms.Label lblCustomerValue;

        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Label lblStaffTitle;
        public System.Windows.Forms.Label lblStaffValue;

        private System.Windows.Forms.Panel panelReservation;
        private System.Windows.Forms.Label lblReservationTitle;
        public System.Windows.Forms.Label lblReservationValue;

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.lblTopMenuTitle = new System.Windows.Forms.Label();
            this.lblTopMenuValue = new System.Windows.Forms.Label();
            this.panelTotalSales = new System.Windows.Forms.Panel();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.panelTotalPayment = new System.Windows.Forms.Panel();
            this.lblTotalPaymentTitle = new System.Windows.Forms.Label();
            this.lblTotalPaymentValue = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblCustomerValue = new System.Windows.Forms.Label();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.lblStaffValue = new System.Windows.Forms.Label();
            this.panelReservation = new System.Windows.Forms.Panel();
            this.lblReservationTitle = new System.Windows.Forms.Label();
            this.lblReservationValue = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panelTopMenu.SuspendLayout();
            this.panelTotalSales.SuspendLayout();
            this.panelTotalPayment.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.panelReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mainPanel.Controls.Add(this.panelTopMenu);
            this.mainPanel.Controls.Add(this.panelTotalSales);
            this.mainPanel.Controls.Add(this.panelTotalPayment);
            this.mainPanel.Controls.Add(this.panelCustomer);
            this.mainPanel.Controls.Add(this.panelStaff);
            this.mainPanel.Controls.Add(this.panelReservation);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(620, 320);
            this.mainPanel.TabIndex = 0;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(16)))), ((int)(((byte)(75)))));
            this.panelTopMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopMenu.Controls.Add(this.lblTopMenuTitle);
            this.panelTopMenu.Controls.Add(this.lblTopMenuValue);
            this.panelTopMenu.Location = new System.Drawing.Point(120, 20);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(420, 88);
            this.panelTopMenu.TabIndex = 0;
            this.panelTopMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopMenu_Paint);
            // 
            // lblTopMenuTitle
            // 
            this.lblTopMenuTitle.AutoSize = true;
            this.lblTopMenuTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTopMenuTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblTopMenuTitle.Location = new System.Drawing.Point(22, 11);
            this.lblTopMenuTitle.Name = "lblTopMenuTitle";
            this.lblTopMenuTitle.Size = new System.Drawing.Size(212, 30);
            this.lblTopMenuTitle.TabIndex = 0;
            this.lblTopMenuTitle.Text = "En Çok Satan Menü";
            // 
            // lblTopMenuValue
            // 
            this.lblTopMenuValue.AutoSize = true;
            this.lblTopMenuValue.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTopMenuValue.ForeColor = System.Drawing.Color.White;
            this.lblTopMenuValue.Location = new System.Drawing.Point(22, 42);
            this.lblTopMenuValue.Name = "lblTopMenuValue";
            this.lblTopMenuValue.Size = new System.Drawing.Size(34, 47);
            this.lblTopMenuValue.TabIndex = 1;
            this.lblTopMenuValue.Text = "-";
            // 
            // panelTotalSales
            // 
            this.panelTotalSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(35)))));
            this.panelTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalSales.Controls.Add(this.lblTotalSalesTitle);
            this.panelTotalSales.Controls.Add(this.lblTotalSalesValue);
            this.panelTotalSales.Location = new System.Drawing.Point(24, 130);
            this.panelTotalSales.Name = "panelTotalSales";
            this.panelTotalSales.Size = new System.Drawing.Size(170, 80);
            this.panelTotalSales.TabIndex = 1;
            // 
            // lblTotalSalesTitle
            // 
            this.lblTotalSalesTitle.AutoSize = true;
            this.lblTotalSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalSalesTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTotalSalesTitle.Name = "lblTotalSalesTitle";
            this.lblTotalSalesTitle.Size = new System.Drawing.Size(112, 23);
            this.lblTotalSalesTitle.TabIndex = 0;
            this.lblTotalSalesTitle.Text = "Toplam Satış";
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalSalesValue.Location = new System.Drawing.Point(14, 36);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.Size = new System.Drawing.Size(59, 40);
            this.lblTotalSalesValue.TabIndex = 1;
            this.lblTotalSalesValue.Text = "0 ₺";
            // 
            // panelTotalPayment
            // 
            this.panelTotalPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.panelTotalPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalPayment.Controls.Add(this.lblTotalPaymentTitle);
            this.panelTotalPayment.Controls.Add(this.lblTotalPaymentValue);
            this.panelTotalPayment.Location = new System.Drawing.Point(218, 130);
            this.panelTotalPayment.Name = "panelTotalPayment";
            this.panelTotalPayment.Size = new System.Drawing.Size(170, 80);
            this.panelTotalPayment.TabIndex = 2;
            // 
            // lblTotalPaymentTitle
            // 
            this.lblTotalPaymentTitle.AutoSize = true;
            this.lblTotalPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalPaymentTitle.Location = new System.Drawing.Point(14, 10);
            this.lblTotalPaymentTitle.Name = "lblTotalPaymentTitle";
            this.lblTotalPaymentTitle.Size = new System.Drawing.Size(132, 23);
            this.lblTotalPaymentTitle.TabIndex = 0;
            this.lblTotalPaymentTitle.Text = "Toplam Ödeme";
            // 
            // lblTotalPaymentValue
            // 
            this.lblTotalPaymentValue.AutoSize = true;
            this.lblTotalPaymentValue.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaymentValue.ForeColor = System.Drawing.Color.Orange;
            this.lblTotalPaymentValue.Location = new System.Drawing.Point(14, 36);
            this.lblTotalPaymentValue.Name = "lblTotalPaymentValue";
            this.lblTotalPaymentValue.Size = new System.Drawing.Size(59, 40);
            this.lblTotalPaymentValue.TabIndex = 1;
            this.lblTotalPaymentValue.Text = "0 ₺";
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.panelCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomer.Controls.Add(this.lblCustomerTitle);
            this.panelCustomer.Controls.Add(this.lblCustomerValue);
            this.panelCustomer.Location = new System.Drawing.Point(412, 130);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(170, 80);
            this.panelCustomer.TabIndex = 3;
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomerTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCustomerTitle.Location = new System.Drawing.Point(14, 10);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(71, 23);
            this.lblCustomerTitle.TabIndex = 0;
            this.lblCustomerTitle.Text = "Müşteri";
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.AutoSize = true;
            this.lblCustomerValue.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblCustomerValue.ForeColor = System.Drawing.Color.Cyan;
            this.lblCustomerValue.Location = new System.Drawing.Point(14, 36);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(34, 40);
            this.lblCustomerValue.TabIndex = 1;
            this.lblCustomerValue.Text = "0";
            // 
            // panelStaff
            // 
            this.panelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panelStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStaff.Controls.Add(this.lblStaffTitle);
            this.panelStaff.Controls.Add(this.lblStaffValue);
            this.panelStaff.Location = new System.Drawing.Point(24, 225);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(170, 80);
            this.panelStaff.TabIndex = 4;
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStaffTitle.Location = new System.Drawing.Point(14, 10);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(76, 23);
            this.lblStaffTitle.TabIndex = 0;
            this.lblStaffTitle.Text = "Personel";
            // 
            // lblStaffValue
            // 
            this.lblStaffValue.AutoSize = true;
            this.lblStaffValue.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblStaffValue.ForeColor = System.Drawing.Color.Gold;
            this.lblStaffValue.Location = new System.Drawing.Point(14, 36);
            this.lblStaffValue.Name = "lblStaffValue";
            this.lblStaffValue.Size = new System.Drawing.Size(34, 40);
            this.lblStaffValue.TabIndex = 1;
            this.lblStaffValue.Text = "0";
            // 
            // panelReservation
            // 
            this.panelReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.panelReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReservation.Controls.Add(this.lblReservationTitle);
            this.panelReservation.Controls.Add(this.lblReservationValue);
            this.panelReservation.Location = new System.Drawing.Point(218, 225);
            this.panelReservation.Name = "panelReservation";
            this.panelReservation.Size = new System.Drawing.Size(170, 80);
            this.panelReservation.TabIndex = 5;
            // 
            // lblReservationTitle
            // 
            this.lblReservationTitle.AutoSize = true;
            this.lblReservationTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReservationTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReservationTitle.Location = new System.Drawing.Point(14, 10);
            this.lblReservationTitle.Name = "lblReservationTitle";
            this.lblReservationTitle.Size = new System.Drawing.Size(109, 23);
            this.lblReservationTitle.TabIndex = 0;
            this.lblReservationTitle.Text = "Rezervasyon";
            // 
            // lblReservationValue
            // 
            this.lblReservationValue.AutoSize = true;
            this.lblReservationValue.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblReservationValue.ForeColor = System.Drawing.Color.Violet;
            this.lblReservationValue.Location = new System.Drawing.Point(14, 36);
            this.lblReservationValue.Name = "lblReservationValue";
            this.lblReservationValue.Size = new System.Drawing.Size(34, 40);
            this.lblReservationValue.TabIndex = 1;
            this.lblReservationValue.Text = "0";
            // 
            // StatisticsUserControl
            // 
            this.Controls.Add(this.mainPanel);
            this.Name = "StatisticsUserControl";
            this.Size = new System.Drawing.Size(620, 320);
            this.mainPanel.ResumeLayout(false);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.panelTotalSales.ResumeLayout(false);
            this.panelTotalSales.PerformLayout();
            this.panelTotalPayment.ResumeLayout(false);
            this.panelTotalPayment.PerformLayout();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.panelReservation.ResumeLayout(false);
            this.panelReservation.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
