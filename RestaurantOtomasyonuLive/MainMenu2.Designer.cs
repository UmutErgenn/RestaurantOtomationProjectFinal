using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    partial class MainMenu2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu2));
            this.btn_mainExit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pBox_Background = new System.Windows.Forms.PictureBox();
            this.lbl_restaurantNameText = new System.Windows.Forms.Label();
            this.pBox_restaurantLogo = new System.Windows.Forms.PictureBox();
            this.flowLP_campaigns = new System.Windows.Forms.FlowLayoutPanel();
            this.pBox_campaign1 = new System.Windows.Forms.PictureBox();
            this.pBox_campaign2 = new System.Windows.Forms.PictureBox();
            this.pBox_campaign3 = new System.Windows.Forms.PictureBox();
            this.lbl_campaign1 = new System.Windows.Forms.Label();
            this.lbl_campaign2 = new System.Windows.Forms.Label();
            this.lbl_campaign3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Hakkımızda = new System.Windows.Forms.Button();
            this.btn_Yardım = new System.Windows.Forms.Button();
            this.btn_Rezervasyon = new System.Windows.Forms.Button();
            this.btn_Siparişlerim = new System.Windows.Forms.Button();
            this.btn_Menü = new System.Windows.Forms.Button();
            this.btn_Ana_Menü = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.lbl_CartText = new System.Windows.Forms.Label();
            this.lbl_AccountText = new System.Windows.Forms.Label();
            this.pBox_CartLogo = new System.Windows.Forms.PictureBox();
            this.pBox_AccountLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_restaurantLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_campaign1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_campaign2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_campaign3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CartLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AccountLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mainExit
            // 
            this.btn_mainExit.BackColor = System.Drawing.Color.Black;
            this.btn_mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainExit.ForeColor = System.Drawing.Color.White;
            this.btn_mainExit.Location = new System.Drawing.Point(857, 0);
            this.btn_mainExit.Name = "btn_mainExit";
            this.btn_mainExit.Size = new System.Drawing.Size(25, 27);
            this.btn_mainExit.TabIndex = 10;
            this.btn_mainExit.Text = "X";
            this.btn_mainExit.UseVisualStyleBackColor = false;
            this.btn_mainExit.Click += new System.EventHandler(this.btn_mainExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pBox_Background
            // 
            this.pBox_Background.BackColor = System.Drawing.Color.Black;
            this.pBox_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBox_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_Background.Location = new System.Drawing.Point(0, 0);
            this.pBox_Background.Name = "pBox_Background";
            this.pBox_Background.Size = new System.Drawing.Size(882, 531);
            this.pBox_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_Background.TabIndex = 0;
            this.pBox_Background.TabStop = false;
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
            // flowLP_campaigns
            // 
            this.flowLP_campaigns.AutoSize = true;
            this.flowLP_campaigns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLP_campaigns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLP_campaigns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLP_campaigns.Location = new System.Drawing.Point(55, 114);
            this.flowLP_campaigns.Margin = new System.Windows.Forms.Padding(1);
            this.flowLP_campaigns.Name = "flowLP_campaigns";
            this.flowLP_campaigns.Size = new System.Drawing.Size(0, 0);
            this.flowLP_campaigns.TabIndex = 13;
            this.flowLP_campaigns.WrapContents = false;
            // 
            // pBox_campaign1
            // 
            this.pBox_campaign1.Location = new System.Drawing.Point(0, 0);
            this.pBox_campaign1.Name = "pBox_campaign1";
            this.pBox_campaign1.Size = new System.Drawing.Size(100, 50);
            this.pBox_campaign1.TabIndex = 0;
            this.pBox_campaign1.TabStop = false;
            // 
            // pBox_campaign2
            // 
            this.pBox_campaign2.Location = new System.Drawing.Point(0, 0);
            this.pBox_campaign2.Name = "pBox_campaign2";
            this.pBox_campaign2.Size = new System.Drawing.Size(100, 50);
            this.pBox_campaign2.TabIndex = 0;
            this.pBox_campaign2.TabStop = false;
            // 
            // pBox_campaign3
            // 
            this.pBox_campaign3.Location = new System.Drawing.Point(0, 0);
            this.pBox_campaign3.Name = "pBox_campaign3";
            this.pBox_campaign3.Size = new System.Drawing.Size(100, 50);
            this.pBox_campaign3.TabIndex = 0;
            this.pBox_campaign3.TabStop = false;
            // 
            // lbl_campaign1
            // 
            this.lbl_campaign1.Location = new System.Drawing.Point(0, 0);
            this.lbl_campaign1.Name = "lbl_campaign1";
            this.lbl_campaign1.Size = new System.Drawing.Size(100, 23);
            this.lbl_campaign1.TabIndex = 0;
            // 
            // lbl_campaign2
            // 
            this.lbl_campaign2.Location = new System.Drawing.Point(0, 0);
            this.lbl_campaign2.Name = "lbl_campaign2";
            this.lbl_campaign2.Size = new System.Drawing.Size(100, 23);
            this.lbl_campaign2.TabIndex = 0;
            // 
            // lbl_campaign3
            // 
            this.lbl_campaign3.Location = new System.Drawing.Point(0, 0);
            this.lbl_campaign3.Name = "lbl_campaign3";
            this.lbl_campaign3.Size = new System.Drawing.Size(100, 23);
            this.lbl_campaign3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btn_Hakkımızda);
            this.panel2.Controls.Add(this.btn_Yardım);
            this.panel2.Controls.Add(this.btn_Rezervasyon);
            this.panel2.Controls.Add(this.btn_Siparişlerim);
            this.panel2.Controls.Add(this.btn_Menü);
            this.panel2.Controls.Add(this.btn_Ana_Menü);
            this.panel2.Controls.Add(this.pBox_restaurantLogo);
            this.panel2.Controls.Add(this.lbl_restaurantNameText);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 531);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btn_Hakkımızda
            // 
            this.btn_Hakkımızda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Hakkımızda.FlatAppearance.BorderSize = 0;
            this.btn_Hakkımızda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hakkımızda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hakkımızda.ForeColor = System.Drawing.Color.White;
            this.btn_Hakkımızda.Location = new System.Drawing.Point(13, 392);
            this.btn_Hakkımızda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Hakkımızda.Name = "btn_Hakkımızda";
            this.btn_Hakkımızda.Size = new System.Drawing.Size(165, 32);
            this.btn_Hakkımızda.TabIndex = 19;
            this.btn_Hakkımızda.Text = "Hakkımıza";
            this.btn_Hakkımızda.UseVisualStyleBackColor = false;
            // 
            // btn_Yardım
            // 
            this.btn_Yardım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Yardım.FlatAppearance.BorderSize = 0;
            this.btn_Yardım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yardım.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yardım.ForeColor = System.Drawing.Color.White;
            this.btn_Yardım.Location = new System.Drawing.Point(13, 348);
            this.btn_Yardım.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Yardım.Name = "btn_Yardım";
            this.btn_Yardım.Size = new System.Drawing.Size(165, 32);
            this.btn_Yardım.TabIndex = 17;
            this.btn_Yardım.Text = "Yardım";
            this.btn_Yardım.UseVisualStyleBackColor = false;
            // 
            // btn_Rezervasyon
            // 
            this.btn_Rezervasyon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Rezervasyon.FlatAppearance.BorderSize = 0;
            this.btn_Rezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rezervasyon.ForeColor = System.Drawing.Color.White;
            this.btn_Rezervasyon.Location = new System.Drawing.Point(13, 304);
            this.btn_Rezervasyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Rezervasyon.Name = "btn_Rezervasyon";
            this.btn_Rezervasyon.Size = new System.Drawing.Size(165, 32);
            this.btn_Rezervasyon.TabIndex = 16;
            this.btn_Rezervasyon.Text = "Rezervasyon";
            this.btn_Rezervasyon.UseVisualStyleBackColor = false;
            this.btn_Rezervasyon.Click += new System.EventHandler(this.btn_Rezervasyon_Click);
            // 
            // btn_Siparişlerim
            // 
            this.btn_Siparişlerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Siparişlerim.FlatAppearance.BorderSize = 0;
            this.btn_Siparişlerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Siparişlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Siparişlerim.ForeColor = System.Drawing.Color.White;
            this.btn_Siparişlerim.Location = new System.Drawing.Point(13, 260);
            this.btn_Siparişlerim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Siparişlerim.Name = "btn_Siparişlerim";
            this.btn_Siparişlerim.Size = new System.Drawing.Size(165, 32);
            this.btn_Siparişlerim.TabIndex = 15;
            this.btn_Siparişlerim.Text = "Siparişlerim";
            this.btn_Siparişlerim.UseVisualStyleBackColor = false;
            // 
            // btn_Menü
            // 
            this.btn_Menü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Menü.FlatAppearance.BorderSize = 0;
            this.btn_Menü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menü.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Menü.ForeColor = System.Drawing.Color.White;
            this.btn_Menü.Location = new System.Drawing.Point(13, 216);
            this.btn_Menü.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Menü.Name = "btn_Menü";
            this.btn_Menü.Size = new System.Drawing.Size(165, 32);
            this.btn_Menü.TabIndex = 14;
            this.btn_Menü.Text = "Menü";
            this.btn_Menü.UseVisualStyleBackColor = false;
            // 
            // btn_Ana_Menü
            // 
            this.btn_Ana_Menü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Ana_Menü.FlatAppearance.BorderSize = 0;
            this.btn_Ana_Menü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ana_Menü.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ana_Menü.ForeColor = System.Drawing.Color.White;
            this.btn_Ana_Menü.Location = new System.Drawing.Point(13, 172);
            this.btn_Ana_Menü.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_Ana_Menü.Name = "btn_Ana_Menü";
            this.btn_Ana_Menü.Size = new System.Drawing.Size(165, 32);
            this.btn_Ana_Menü.TabIndex = 13;
            this.btn_Ana_Menü.Text = "Ana Menü";
            this.btn_Ana_Menü.UseVisualStyleBackColor = false;
            this.btn_Ana_Menü.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMenu.BackgroundImage")));
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.lbl_CartText);
            this.PanelMenu.Controls.Add(this.lbl_AccountText);
            this.PanelMenu.Controls.Add(this.pBox_CartLogo);
            this.PanelMenu.Controls.Add(this.pBox_AccountLogo);
            this.PanelMenu.Controls.Add(this.flowLP_campaigns);
            this.PanelMenu.Location = new System.Drawing.Point(188, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(1);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(694, 531);
            this.PanelMenu.TabIndex = 16;
            // 
            // lbl_CartText
            // 
            this.lbl_CartText.AutoSize = true;
            this.lbl_CartText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CartText.ForeColor = System.Drawing.Color.White;
            this.lbl_CartText.Location = new System.Drawing.Point(540, 52);
            this.lbl_CartText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CartText.Name = "lbl_CartText";
            this.lbl_CartText.Size = new System.Drawing.Size(66, 17);
            this.lbl_CartText.TabIndex = 24;
            this.lbl_CartText.Text = "Sepetim";
            // 
            // lbl_AccountText
            // 
            this.lbl_AccountText.AutoSize = true;
            this.lbl_AccountText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AccountText.ForeColor = System.Drawing.Color.White;
            this.lbl_AccountText.Location = new System.Drawing.Point(439, 52);
            this.lbl_AccountText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_AccountText.Name = "lbl_AccountText";
            this.lbl_AccountText.Size = new System.Drawing.Size(70, 17);
            this.lbl_AccountText.TabIndex = 23;
            this.lbl_AccountText.Text = "Hesabım";
            // 
            // pBox_CartLogo
            // 
            this.pBox_CartLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_CartLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_CartLogo.BackgroundImage")));
            this.pBox_CartLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_CartLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBox_CartLogo.Location = new System.Drawing.Point(552, 10);
            this.pBox_CartLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_CartLogo.Name = "pBox_CartLogo";
            this.pBox_CartLogo.Size = new System.Drawing.Size(41, 45);
            this.pBox_CartLogo.TabIndex = 26;
            this.pBox_CartLogo.TabStop = false;
            // 
            // pBox_AccountLogo
            // 
            this.pBox_AccountLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_AccountLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_AccountLogo.BackgroundImage")));
            this.pBox_AccountLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_AccountLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBox_AccountLogo.Location = new System.Drawing.Point(454, 10);
            this.pBox_AccountLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBox_AccountLogo.Name = "pBox_AccountLogo";
            this.pBox_AccountLogo.Size = new System.Drawing.Size(41, 45);
            this.pBox_AccountLogo.TabIndex = 25;
            this.pBox_AccountLogo.TabStop = false;
            // 
            // MainMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(882, 531);
            this.Controls.Add(this.btn_mainExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.pBox_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_restaurantLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_campaign1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_campaign2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_campaign3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CartLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AccountLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_mainExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private PictureBox pBox_Background;
        private Label lbl_restaurantNameText;
        private PictureBox pBox_restaurantLogo;
        private FlowLayoutPanel flowLP_campaigns;
        public PictureBox pBox_campaign1;
        public PictureBox pBox_campaign2;
        public PictureBox pBox_campaign3;
        private Label lbl_campaign1;
        private Label lbl_campaign2;
        private Label lbl_campaign3;
        private Panel panel2;
        private Panel PanelMenu;
        private Button btn_Ana_Menü;
        private Button btn_Hakkımızda;
        private Button btn_Yardım;
        private Button btn_Rezervasyon;
        private Button btn_Siparişlerim;
        private Button btn_Menü;
        private Label lbl_CartText;
        private Label lbl_AccountText;
        private PictureBox pBox_CartLogo;
        private PictureBox pBox_AccountLogo;
        private PictureBox pictureBox3;
    }
}