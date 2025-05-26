namespace RestaurantOtomasyonuLive
{
    partial class StaffForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Kitchen = new System.Windows.Forms.Button();
            this.btn_Waiter = new System.Windows.Forms.Button();
            this.pBox_restaurantLogo = new System.Windows.Forms.PictureBox();
            this.lbl_restaurantNameText = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.pnlWaiter = new System.Windows.Forms.Panel();
            this.dgvWaiterOrders = new System.Windows.Forms.DataGridView();
            this.btnOrderDetail = new System.Windows.Forms.Button();
            this.btnOrderApprove = new System.Windows.Forms.Button();
            this.btnOrderReject = new System.Windows.Forms.Button();
            this.pnlKitchen = new System.Windows.Forms.Panel();
            this.dgvKitchenOrders = new System.Windows.Forms.DataGridView();
            this.pnlDefault = new System.Windows.Forms.Panel();
            this.btn_mainExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_restaurantLogo)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.pnlWaiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiterOrders)).BeginInit();
            this.pnlKitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitchenOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btn_Kitchen);
            this.panel2.Controls.Add(this.btn_Waiter);
            this.panel2.Controls.Add(this.pBox_restaurantLogo);
            this.panel2.Controls.Add(this.lbl_restaurantNameText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 531);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(157, 499);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Kitchen
            // 
            this.btn_Kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Kitchen.FlatAppearance.BorderSize = 0;
            this.btn_Kitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kitchen.ForeColor = System.Drawing.Color.White;
            this.btn_Kitchen.Location = new System.Drawing.Point(13, 216);
            this.btn_Kitchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Kitchen.Name = "btn_Kitchen";
            this.btn_Kitchen.Size = new System.Drawing.Size(165, 32);
            this.btn_Kitchen.TabIndex = 14;
            this.btn_Kitchen.Text = "Mutfak Paneli";
            this.btn_Kitchen.UseVisualStyleBackColor = false;
            this.btn_Kitchen.Click += new System.EventHandler(this.btn_Kitchen_Click);
            // 
            // btn_Waiter
            // 
            this.btn_Waiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Waiter.FlatAppearance.BorderSize = 0;
            this.btn_Waiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Waiter.ForeColor = System.Drawing.Color.White;
            this.btn_Waiter.Location = new System.Drawing.Point(13, 172);
            this.btn_Waiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Waiter.Name = "btn_Waiter";
            this.btn_Waiter.Size = new System.Drawing.Size(165, 32);
            this.btn_Waiter.TabIndex = 13;
            this.btn_Waiter.Text = "Garson Paneli";
            this.btn_Waiter.UseVisualStyleBackColor = false;
            this.btn_Waiter.Click += new System.EventHandler(this.btn_Waiter_Click);
            // 
            // pBox_restaurantLogo
            // 
            this.pBox_restaurantLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_restaurantLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_restaurantLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_restaurantLogo.BackgroundImage")));
            this.pBox_restaurantLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_restaurantLogo.Location = new System.Drawing.Point(48, 46);
            this.pBox_restaurantLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pBox_restaurantLogo.Name = "pBox_restaurantLogo";
            this.pBox_restaurantLogo.Size = new System.Drawing.Size(95, 107);
            this.pBox_restaurantLogo.TabIndex = 11;
            this.pBox_restaurantLogo.TabStop = false;
            // 
            // lbl_restaurantNameText
            // 
            this.lbl_restaurantNameText.AutoSize = true;
            this.lbl_restaurantNameText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_restaurantNameText.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restaurantNameText.ForeColor = System.Drawing.Color.White;
            this.lbl_restaurantNameText.Location = new System.Drawing.Point(9, 20);
            this.lbl_restaurantNameText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_restaurantNameText.Name = "lbl_restaurantNameText";
            this.lbl_restaurantNameText.Size = new System.Drawing.Size(171, 26);
            this.lbl_restaurantNameText.TabIndex = 12;
            this.lbl_restaurantNameText.Text = "Mola Restoran";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMenu.BackgroundImage")));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.btn_mainExit);
            this.PanelMenu.Controls.Add(this.pnlKitchen);
            this.PanelMenu.Controls.Add(this.pnlDefault);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(188, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(1);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(694, 531);
            this.PanelMenu.TabIndex = 18;
            // 
            // pnlWaiter
            // 
            this.pnlWaiter.Controls.Add(this.dgvWaiterOrders);
            this.pnlWaiter.Controls.Add(this.btnOrderDetail);
            this.pnlWaiter.Controls.Add(this.btnOrderApprove);
            this.pnlWaiter.Controls.Add(this.btnOrderReject);
            this.pnlWaiter.Location = new System.Drawing.Point(0, 0);
            this.pnlWaiter.Name = "pnlWaiter";
            this.pnlWaiter.Size = new System.Drawing.Size(600, 300);
            this.pnlWaiter.TabIndex = 27;
            this.pnlWaiter.Visible = false;
            // 
            // dgvWaiterOrders
            // 
            this.dgvWaiterOrders.Location = new System.Drawing.Point(10, 10);
            this.dgvWaiterOrders.Name = "dgvWaiterOrders";
            this.dgvWaiterOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWaiterOrders.Size = new System.Drawing.Size(563, 200);
            this.dgvWaiterOrders.TabIndex = 0;
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.Location = new System.Drawing.Point(226, 267);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(100, 30);
            this.btnOrderDetail.TabIndex = 1;
            this.btnOrderDetail.Text = "Detay Gör";
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // btnOrderApprove
            // 
            this.btnOrderApprove.Location = new System.Drawing.Point(497, 267);
            this.btnOrderApprove.Name = "btnOrderApprove";
            this.btnOrderApprove.Size = new System.Drawing.Size(100, 30);
            this.btnOrderApprove.TabIndex = 2;
            this.btnOrderApprove.Text = "Onayla";
            this.btnOrderApprove.Click += new System.EventHandler(this.btnOrderApprove_Click);
            // 
            // btnOrderReject
            // 
            this.btnOrderReject.Location = new System.Drawing.Point(391, 267);
            this.btnOrderReject.Name = "btnOrderReject";
            this.btnOrderReject.Size = new System.Drawing.Size(100, 30);
            this.btnOrderReject.TabIndex = 3;
            this.btnOrderReject.Text = "Reddet";
            this.btnOrderReject.Click += new System.EventHandler(this.btnOrderReject_Click);
            // 
            // pnlKitchen
            // 
            this.pnlKitchen.Controls.Add(this.dgvKitchenOrders);
            this.pnlKitchen.Controls.Add(this.pnlWaiter);
            this.pnlKitchen.Location = new System.Drawing.Point(20, 70);
            this.pnlKitchen.Name = "pnlKitchen";
            this.pnlKitchen.Size = new System.Drawing.Size(600, 300);
            this.pnlKitchen.TabIndex = 28;
            this.pnlKitchen.Visible = false;
            // 
            // dgvKitchenOrders
            // 
            this.dgvKitchenOrders.Location = new System.Drawing.Point(10, 10);
            this.dgvKitchenOrders.Name = "dgvKitchenOrders";
            this.dgvKitchenOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitchenOrders.Size = new System.Drawing.Size(563, 200);
            this.dgvKitchenOrders.TabIndex = 0;
            // 
            // pnlDefault
            // 
            this.pnlDefault.Location = new System.Drawing.Point(20, 70);
            this.pnlDefault.Name = "pnlDefault";
            this.pnlDefault.Size = new System.Drawing.Size(600, 300);
            this.pnlDefault.TabIndex = 29;
            // 
            // btn_mainExit
            // 
            this.btn_mainExit.BackColor = System.Drawing.Color.Black;
            this.btn_mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainExit.ForeColor = System.Drawing.Color.White;
            this.btn_mainExit.Location = new System.Drawing.Point(669, 0);
            this.btn_mainExit.Name = "btn_mainExit";
            this.btn_mainExit.Size = new System.Drawing.Size(25, 27);
            this.btn_mainExit.TabIndex = 30;
            this.btn_mainExit.Text = "X";
            this.btn_mainExit.UseVisualStyleBackColor = false;
            this.btn_mainExit.Click += new System.EventHandler(this.btn_mainExit_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 531);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_restaurantLogo)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.pnlWaiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaiterOrders)).EndInit();
            this.pnlKitchen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitchenOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Kitchen;
        private System.Windows.Forms.Button btn_Waiter;
        private System.Windows.Forms.PictureBox pBox_restaurantLogo;
        private System.Windows.Forms.Label lbl_restaurantNameText;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel pnlWaiter;
        private System.Windows.Forms.Panel pnlKitchen;
        private System.Windows.Forms.Panel pnlDefault;
        private System.Windows.Forms.DataGridView dgvWaiterOrders;
        private System.Windows.Forms.DataGridView dgvKitchenOrders;
        private System.Windows.Forms.Button btnOrderDetail;
        private System.Windows.Forms.Button btnOrderApprove;
        private System.Windows.Forms.Button btnOrderReject;
        private System.Windows.Forms.Button btn_mainExit;
    }
}