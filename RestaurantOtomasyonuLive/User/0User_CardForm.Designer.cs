namespace RestaurantOtomasyonuLive
{
    partial class User_CardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_CardForm));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_increase = new System.Windows.Forms.Button();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_card_approve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(694, 531);
            this.dataGridView3.TabIndex = 22;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_total.Location = new System.Drawing.Point(308, 484);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(98, 31);
            this.lbl_total.TabIndex = 27;
            this.lbl_total.Text = "250 TL";
            // 
            // btn_increase
            // 
            this.btn_increase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_increase.FlatAppearance.BorderSize = 0;
            this.btn_increase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_increase.ForeColor = System.Drawing.Color.White;
            this.btn_increase.Location = new System.Drawing.Point(214, 484);
            this.btn_increase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(35, 32);
            this.btn_increase.TabIndex = 23;
            this.btn_increase.Text = "+";
            this.btn_increase.UseVisualStyleBackColor = false;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // btn_decrease
            // 
            this.btn_decrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_decrease.FlatAppearance.BorderSize = 0;
            this.btn_decrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_decrease.ForeColor = System.Drawing.Color.White;
            this.btn_decrease.Location = new System.Drawing.Point(172, 484);
            this.btn_decrease.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(35, 32);
            this.btn_decrease.TabIndex = 24;
            this.btn_decrease.Text = "-";
            this.btn_decrease.UseVisualStyleBackColor = false;
            this.btn_decrease.Click += new System.EventHandler(this.btn_decrease_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(10, 484);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(154, 32);
            this.btn_remove.TabIndex = 25;
            this.btn_remove.Text = "Çıkart";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_card_approve
            // 
            this.btn_card_approve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btn_card_approve.FlatAppearance.BorderSize = 0;
            this.btn_card_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_card_approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_card_approve.ForeColor = System.Drawing.Color.White;
            this.btn_card_approve.Location = new System.Drawing.Point(520, 484);
            this.btn_card_approve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 8);
            this.btn_card_approve.Name = "btn_card_approve";
            this.btn_card_approve.Size = new System.Drawing.Size(151, 32);
            this.btn_card_approve.TabIndex = 26;
            this.btn_card_approve.Text = "Sepeti Onayla";
            this.btn_card_approve.UseVisualStyleBackColor = false;
            this.btn_card_approve.Click += new System.EventHandler(this.btn_card_approve_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 531);
            this.panel1.TabIndex = 28;
            // 
            // User_CardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(694, 531);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_card_approve);
            this.Controls.Add(this.btn_increase);
            this.Controls.Add(this.btn_decrease);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardForm";
            this.Load += new System.EventHandler(this.CardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_card_approve;
        private System.Windows.Forms.Panel panel1;
    }
}