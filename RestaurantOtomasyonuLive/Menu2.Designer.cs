using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    partial class Menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelEx = new System.Windows.Forms.FlowLayoutPanel();
            this.urun_name = new System.Windows.Forms.Label();
            this.urun_resim = new System.Windows.Forms.PictureBox();
            this.urun_desc = new System.Windows.Forms.Label();
            this.label_fiyat = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLP_campaigns = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_mainExit = new System.Windows.Forms.Button();
            this.lbl_CartText = new System.Windows.Forms.Label();
            this.lbl_AccountText = new System.Windows.Forms.Label();
            this.pBox_CartLogo = new System.Windows.Forms.PictureBox();
            this.pBox_AccountLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Hakkımızda = new System.Windows.Forms.Button();
            this.btn_Yardım = new System.Windows.Forms.Button();
            this.btn_Rezervasyon = new System.Windows.Forms.Button();
            this.btn_Siparişlerim = new System.Windows.Forms.Button();
            this.btn_Menü = new System.Windows.Forms.Button();
            this.btn_Ana_Menü = new System.Windows.Forms.Button();
            this.pBox_restaurantLogo = new System.Windows.Forms.PictureBox();
            this.lbl_restaurantNameText = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanelEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_resim)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CartLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AccountLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_restaurantLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.flowLayoutPanelEx);
            this.panelMenu.Controls.Add(this.flowLayoutMainPanel);
            this.panelMenu.Controls.Add(this.btn_mainExit);
            this.panelMenu.Controls.Add(this.lbl_CartText);
            this.panelMenu.Controls.Add(this.lbl_AccountText);
            this.panelMenu.Controls.Add(this.pBox_CartLogo);
            this.panelMenu.Controls.Add(this.pBox_AccountLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(251, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(949, 654);
            this.panelMenu.TabIndex = 18;
            // 
            // flowLayoutPanelEx
            // 
            this.flowLayoutPanelEx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanelEx.BackgroundImage")));
            this.flowLayoutPanelEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanelEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelEx.Controls.Add(this.urun_name);
            this.flowLayoutPanelEx.Controls.Add(this.urun_resim);
            this.flowLayoutPanelEx.Controls.Add(this.urun_desc);
            this.flowLayoutPanelEx.Controls.Add(this.label_fiyat);
            this.flowLayoutPanelEx.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanelEx.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelEx.Location = new System.Drawing.Point(328, 132);
            this.flowLayoutPanelEx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelEx.Name = "flowLayoutPanelEx";
            this.flowLayoutPanelEx.Size = new System.Drawing.Size(313, 423);
            this.flowLayoutPanelEx.TabIndex = 31;
            this.flowLayoutPanelEx.Visible = false;
            // 
            // urun_name
            // 
            this.urun_name.AutoSize = true;
            this.urun_name.BackColor = System.Drawing.Color.Transparent;
            this.urun_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.urun_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_name.ForeColor = System.Drawing.Color.White;
            this.urun_name.Location = new System.Drawing.Point(0, 0);
            this.urun_name.Margin = new System.Windows.Forms.Padding(0);
            this.urun_name.Name = "urun_name";
            this.urun_name.Size = new System.Drawing.Size(317, 24);
            this.urun_name.TabIndex = 0;
            this.urun_name.Text = "ürün adı";
            this.urun_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urun_resim
            // 
            this.urun_resim.Location = new System.Drawing.Point(0, 28);
            this.urun_resim.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.urun_resim.Name = "urun_resim";
            this.urun_resim.Size = new System.Drawing.Size(313, 156);
            this.urun_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urun_resim.TabIndex = 1;
            this.urun_resim.TabStop = false;
            // 
            // urun_desc
            // 
            this.urun_desc.BackColor = System.Drawing.Color.Transparent;
            this.urun_desc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_desc.ForeColor = System.Drawing.Color.White;
            this.urun_desc.Location = new System.Drawing.Point(0, 188);
            this.urun_desc.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.urun_desc.Name = "urun_desc";
            this.urun_desc.Size = new System.Drawing.Size(313, 174);
            this.urun_desc.TabIndex = 2;
            this.urun_desc.Text = "label2";
            // 
            // label_fiyat
            // 
            this.label_fiyat.AutoSize = true;
            this.label_fiyat.BackColor = System.Drawing.Color.Transparent;
            this.label_fiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fiyat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_fiyat.ForeColor = System.Drawing.Color.White;
            this.label_fiyat.Location = new System.Drawing.Point(4, 362);
            this.label_fiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fiyat.Name = "label_fiyat";
            this.label_fiyat.Size = new System.Drawing.Size(309, 22);
            this.label_fiyat.TabIndex = 32;
            this.label_fiyat.Text = "Ürün Fiyatı:";
            this.label_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel7.Controls.Add(this.button1);
            this.flowLayoutPanel7.Controls.Add(this.button2);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(317, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(313, 39);
            this.flowLayoutPanel7.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "İptal et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(193, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sepete ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutMainPanel
            // 
            this.flowLayoutMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutMainPanel.Controls.Add(this.flowLP_campaigns);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutMainPanel.Location = new System.Drawing.Point(28, 143);
            this.flowLayoutMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 51, 2);
            this.flowLayoutMainPanel.Name = "flowLayoutMainPanel";
            this.flowLayoutMainPanel.Size = new System.Drawing.Size(893, 400);
            this.flowLayoutMainPanel.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // flowLP_campaigns
            // 
            this.flowLP_campaigns.AutoSize = true;
            this.flowLP_campaigns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLP_campaigns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLP_campaigns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLP_campaigns.Location = new System.Drawing.Point(7, 1);
            this.flowLP_campaigns.Margin = new System.Windows.Forms.Padding(1);
            this.flowLP_campaigns.Name = "flowLP_campaigns";
            this.flowLP_campaigns.Size = new System.Drawing.Size(0, 0);
            this.flowLP_campaigns.TabIndex = 13;
            this.flowLP_campaigns.WrapContents = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(11, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel3.TabIndex = 31;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(15, 1);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel4.TabIndex = 30;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(19, 2);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel5.TabIndex = 33;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(23, 1);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel6.TabIndex = 32;
            this.flowLayoutPanel6.WrapContents = false;
            // 
            // btn_mainExit
            // 
            this.btn_mainExit.BackColor = System.Drawing.Color.Black;
            this.btn_mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mainExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mainExit.ForeColor = System.Drawing.Color.White;
            this.btn_mainExit.Location = new System.Drawing.Point(892, 0);
            this.btn_mainExit.Margin = new System.Windows.Forms.Padding(1);
            this.btn_mainExit.Name = "btn_mainExit";
            this.btn_mainExit.Size = new System.Drawing.Size(33, 33);
            this.btn_mainExit.TabIndex = 28;
            this.btn_mainExit.Text = "X";
            this.btn_mainExit.UseVisualStyleBackColor = false;
            this.btn_mainExit.Click += new System.EventHandler(this.btn_mainExit_Click);
            // 
            // lbl_CartText
            // 
            this.lbl_CartText.AutoSize = true;
            this.lbl_CartText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CartText.ForeColor = System.Drawing.Color.White;
            this.lbl_CartText.Location = new System.Drawing.Point(721, 54);
            this.lbl_CartText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CartText.Name = "lbl_CartText";
            this.lbl_CartText.Size = new System.Drawing.Size(77, 20);
            this.lbl_CartText.TabIndex = 24;
            this.lbl_CartText.Text = "Sepetim";
            // 
            // lbl_AccountText
            // 
            this.lbl_AccountText.AutoSize = true;
            this.lbl_AccountText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AccountText.ForeColor = System.Drawing.Color.White;
            this.lbl_AccountText.Location = new System.Drawing.Point(585, 54);
            this.lbl_AccountText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_AccountText.Name = "lbl_AccountText";
            this.lbl_AccountText.Size = new System.Drawing.Size(83, 20);
            this.lbl_AccountText.TabIndex = 23;
            this.lbl_AccountText.Text = "Hesabım";
            // 
            // pBox_CartLogo
            // 
            this.pBox_CartLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_CartLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_CartLogo.BackgroundImage")));
            this.pBox_CartLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_CartLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBox_CartLogo.Location = new System.Drawing.Point(737, 2);
            this.pBox_CartLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBox_CartLogo.Name = "pBox_CartLogo";
            this.pBox_CartLogo.Size = new System.Drawing.Size(55, 55);
            this.pBox_CartLogo.TabIndex = 26;
            this.pBox_CartLogo.TabStop = false;
            // 
            // pBox_AccountLogo
            // 
            this.pBox_AccountLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_AccountLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_AccountLogo.BackgroundImage")));
            this.pBox_AccountLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_AccountLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBox_AccountLogo.Location = new System.Drawing.Point(607, 2);
            this.pBox_AccountLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBox_AccountLogo.Name = "pBox_AccountLogo";
            this.pBox_AccountLogo.Size = new System.Drawing.Size(55, 55);
            this.pBox_AccountLogo.TabIndex = 25;
            this.pBox_AccountLogo.TabStop = false;
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 654);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(209, 614);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 5, 5, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 34);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Hakkımızda
            // 
            this.btn_Hakkımızda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Hakkımızda.FlatAppearance.BorderSize = 0;
            this.btn_Hakkımızda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hakkımızda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hakkımızda.ForeColor = System.Drawing.Color.White;
            this.btn_Hakkımızda.Location = new System.Drawing.Point(17, 482);
            this.btn_Hakkımızda.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btn_Hakkımızda.Name = "btn_Hakkımızda";
            this.btn_Hakkımızda.Size = new System.Drawing.Size(220, 39);
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
            this.btn_Yardım.Location = new System.Drawing.Point(17, 428);
            this.btn_Yardım.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btn_Yardım.Name = "btn_Yardım";
            this.btn_Yardım.Size = new System.Drawing.Size(220, 39);
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
            this.btn_Rezervasyon.Location = new System.Drawing.Point(17, 374);
            this.btn_Rezervasyon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btn_Rezervasyon.Name = "btn_Rezervasyon";
            this.btn_Rezervasyon.Size = new System.Drawing.Size(220, 39);
            this.btn_Rezervasyon.TabIndex = 16;
            this.btn_Rezervasyon.Text = "Rezervasyon";
            this.btn_Rezervasyon.UseVisualStyleBackColor = false;
            // 
            // btn_Siparişlerim
            // 
            this.btn_Siparişlerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_Siparişlerim.FlatAppearance.BorderSize = 0;
            this.btn_Siparişlerim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Siparişlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Siparişlerim.ForeColor = System.Drawing.Color.White;
            this.btn_Siparişlerim.Location = new System.Drawing.Point(17, 320);
            this.btn_Siparişlerim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btn_Siparişlerim.Name = "btn_Siparişlerim";
            this.btn_Siparişlerim.Size = new System.Drawing.Size(220, 39);
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
            this.btn_Menü.Location = new System.Drawing.Point(17, 266);
            this.btn_Menü.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btn_Menü.Name = "btn_Menü";
            this.btn_Menü.Size = new System.Drawing.Size(220, 39);
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
            this.btn_Ana_Menü.Location = new System.Drawing.Point(17, 212);
            this.btn_Ana_Menü.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.btn_Ana_Menü.Name = "btn_Ana_Menü";
            this.btn_Ana_Menü.Size = new System.Drawing.Size(220, 39);
            this.btn_Ana_Menü.TabIndex = 13;
            this.btn_Ana_Menü.Text = "Ana Menü";
            this.btn_Ana_Menü.UseVisualStyleBackColor = false;
            // 
            // pBox_restaurantLogo
            // 
            this.pBox_restaurantLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_restaurantLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_restaurantLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_restaurantLogo.BackgroundImage")));
            this.pBox_restaurantLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_restaurantLogo.Location = new System.Drawing.Point(64, 57);
            this.pBox_restaurantLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pBox_restaurantLogo.Name = "pBox_restaurantLogo";
            this.pBox_restaurantLogo.Size = new System.Drawing.Size(127, 132);
            this.pBox_restaurantLogo.TabIndex = 11;
            this.pBox_restaurantLogo.TabStop = false;
            // 
            // lbl_restaurantNameText
            // 
            this.lbl_restaurantNameText.AutoSize = true;
            this.lbl_restaurantNameText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_restaurantNameText.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restaurantNameText.ForeColor = System.Drawing.Color.White;
            this.lbl_restaurantNameText.Location = new System.Drawing.Point(12, 25);
            this.lbl_restaurantNameText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_restaurantNameText.Name = "lbl_restaurantNameText";
            this.lbl_restaurantNameText.Size = new System.Drawing.Size(214, 32);
            this.lbl_restaurantNameText.TabIndex = 12;
            this.lbl_restaurantNameText.Text = "Mola Restoran";
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu2";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flowLayoutPanelEx.ResumeLayout(false);
            this.flowLayoutPanelEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_resim)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutMainPanel.ResumeLayout(false);
            this.flowLayoutMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CartLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AccountLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_restaurantLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_mainExit;
        private System.Windows.Forms.Label lbl_CartText;
        private System.Windows.Forms.Label lbl_AccountText;
        private System.Windows.Forms.PictureBox pBox_CartLogo;
        private System.Windows.Forms.PictureBox pBox_AccountLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLP_campaigns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMainPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private FlowLayoutPanel flowLayoutPanelEx;
        private Label urun_name;
        private PictureBox urun_resim;
        private Label urun_desc;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button button1;
        private Button button2;
        private Label label_fiyat;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button btn_Hakkımızda;
        private Button btn_Yardım;
        private Button btn_Rezervasyon;
        private Button btn_Siparişlerim;
        private Button btn_Menü;
        private Button btn_Ana_Menü;
        private PictureBox pBox_restaurantLogo;
        private Label lbl_restaurantNameText;
    }
}