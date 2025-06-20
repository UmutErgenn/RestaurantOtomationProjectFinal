﻿using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    partial class User_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelEx = new System.Windows.Forms.FlowLayoutPanel();
            this.urun_name = new System.Windows.Forms.Label();
            this.urun_resim = new System.Windows.Forms.PictureBox();
            this.urun_desc = new System.Windows.Forms.Label();
            this.label_fiyat = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.urun_quantity = new System.Windows.Forms.NumericUpDown();
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
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanelEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_resim)).BeginInit();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_quantity)).BeginInit();
            this.flowLayoutMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CartLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AccountLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.lbl_CartText);
            this.panelMenu.Controls.Add(this.lbl_AccountText);
            this.panelMenu.Controls.Add(this.pBox_CartLogo);
            this.panelMenu.Controls.Add(this.pBox_AccountLogo);
            this.panelMenu.Controls.Add(this.flowLayoutPanelEx);
            this.panelMenu.Controls.Add(this.flowLayoutMainPanel);
            this.panelMenu.Controls.Add(this.btn_mainExit);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(694, 531);
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
            this.flowLayoutPanelEx.Location = new System.Drawing.Point(212, 65);
            this.flowLayoutPanelEx.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelEx.Name = "flowLayoutPanelEx";
            this.flowLayoutPanelEx.Size = new System.Drawing.Size(277, 417);
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
            this.urun_name.Size = new System.Drawing.Size(279, 19);
            this.urun_name.TabIndex = 0;
            this.urun_name.Text = "ürün adı";
            this.urun_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urun_resim
            // 
            this.urun_resim.Location = new System.Drawing.Point(0, 23);
            this.urun_resim.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.urun_resim.Name = "urun_resim";
            this.urun_resim.Size = new System.Drawing.Size(275, 156);
            this.urun_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urun_resim.TabIndex = 1;
            this.urun_resim.TabStop = false;
            // 
            // urun_desc
            // 
            this.urun_desc.BackColor = System.Drawing.Color.Transparent;
            this.urun_desc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_desc.ForeColor = System.Drawing.Color.White;
            this.urun_desc.Location = new System.Drawing.Point(0, 183);
            this.urun_desc.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.urun_desc.Name = "urun_desc";
            this.urun_desc.Size = new System.Drawing.Size(275, 174);
            this.urun_desc.TabIndex = 2;
            this.urun_desc.Text = "label2";
            // 
            // label_fiyat
            // 
            this.label_fiyat.AutoSize = true;
            this.label_fiyat.BackColor = System.Drawing.Color.Transparent;
            this.label_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_fiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_fiyat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_fiyat.ForeColor = System.Drawing.Color.White;
            this.label_fiyat.Location = new System.Drawing.Point(0, 357);
            this.label_fiyat.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label_fiyat.Name = "label_fiyat";
            this.label_fiyat.Size = new System.Drawing.Size(275, 19);
            this.label_fiyat.TabIndex = 32;
            this.label_fiyat.Text = "Ürün Fiyatı:";
            this.label_fiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel7.Controls.Add(this.button1);
            this.flowLayoutPanel7.Controls.Add(this.urun_quantity);
            this.flowLayoutPanel7.Controls.Add(this.button2);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 376);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(275, 39);
            this.flowLayoutPanel7.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "İptal et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urun_quantity
            // 
            this.urun_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.urun_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_quantity.ForeColor = System.Drawing.Color.White;
            this.urun_quantity.Location = new System.Drawing.Point(104, 7);
            this.urun_quantity.Margin = new System.Windows.Forms.Padding(4, 7, 4, 4);
            this.urun_quantity.Name = "urun_quantity";
            this.urun_quantity.Size = new System.Drawing.Size(67, 21);
            this.urun_quantity.TabIndex = 33;
            this.urun_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(175, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sepete ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutMainPanel
            // 
            this.flowLayoutMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutMainPanel.Controls.Add(this.flowLP_campaigns);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutMainPanel.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutMainPanel.Location = new System.Drawing.Point(12, 133);
            this.flowLayoutMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 51, 2);
            this.flowLayoutMainPanel.Name = "flowLayoutMainPanel";
            this.flowLayoutMainPanel.Size = new System.Drawing.Size(667, 293);
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
            this.btn_mainExit.Location = new System.Drawing.Point(891, 1);
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
            this.lbl_CartText.Location = new System.Drawing.Point(544, 44);
            this.lbl_CartText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_CartText.Name = "lbl_CartText";
            this.lbl_CartText.Size = new System.Drawing.Size(66, 17);
            this.lbl_CartText.TabIndex = 33;
            this.lbl_CartText.Text = "Sepetim";
            // 
            // lbl_AccountText
            // 
            this.lbl_AccountText.AutoSize = true;
            this.lbl_AccountText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AccountText.ForeColor = System.Drawing.Color.White;
            this.lbl_AccountText.Location = new System.Drawing.Point(442, 44);
            this.lbl_AccountText.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_AccountText.Name = "lbl_AccountText";
            this.lbl_AccountText.Size = new System.Drawing.Size(70, 17);
            this.lbl_AccountText.TabIndex = 32;
            this.lbl_AccountText.Text = "Hesabım";
            // 
            // pBox_CartLogo
            // 
            this.pBox_CartLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_CartLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_CartLogo.BackgroundImage")));
            this.pBox_CartLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBox_CartLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBox_CartLogo.Location = new System.Drawing.Point(556, 2);
            this.pBox_CartLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pBox_CartLogo.Name = "pBox_CartLogo";
            this.pBox_CartLogo.Size = new System.Drawing.Size(41, 45);
            this.pBox_CartLogo.TabIndex = 35;
            this.pBox_CartLogo.TabStop = false;
            this.pBox_CartLogo.Click += new System.EventHandler(this.pBox_CartLogo_Click);
            // 
            // pBox_AccountLogo
            // 
            this.pBox_AccountLogo.BackColor = System.Drawing.Color.Transparent;
            this.pBox_AccountLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBox_AccountLogo.BackgroundImage")));
            this.pBox_AccountLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_AccountLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBox_AccountLogo.Location = new System.Drawing.Point(457, 2);
            this.pBox_AccountLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pBox_AccountLogo.Name = "pBox_AccountLogo";
            this.pBox_AccountLogo.Size = new System.Drawing.Size(41, 45);
            this.pBox_AccountLogo.TabIndex = 34;
            this.pBox_AccountLogo.TabStop = false;
            this.pBox_AccountLogo.Click += new System.EventHandler(this.pBox_AccountLogo_Click);
            // 
            // User_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(694, 531);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu2";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.flowLayoutPanelEx.ResumeLayout(false);
            this.flowLayoutPanelEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urun_resim)).EndInit();
            this.flowLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urun_quantity)).EndInit();
            this.flowLayoutMainPanel.ResumeLayout(false);
            this.flowLayoutMainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CartLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AccountLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
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
        private NumericUpDown urun_quantity;
        private Button btn_mainExit;
        private Label lbl_CartText;
        private Label lbl_AccountText;
        private PictureBox pBox_CartLogo;
        private PictureBox pBox_AccountLogo;
    }
}