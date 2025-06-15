using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    partial class User_About
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Size = new System.Drawing.Size(580, 340);
            this.pnlMain.Location = new System.Drawing.Point(85, 60); // Ortada ve geniş
            this.pnlMain.Anchor = AnchorStyles.None;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.lblInfo);

            // lblTitle
            this.lblTitle.Text = "HAKKIMIZDA";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Size = new System.Drawing.Size(580, 55);
            this.lblTitle.Location = new System.Drawing.Point(0, 15);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // lblInfo
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular);
            this.lblInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInfo.Location = new System.Drawing.Point(40, 80);
            this.lblInfo.Size = new System.Drawing.Size(500, 240);
            this.lblInfo.Text =
@"Mola Restoran; 2024 yılında kurulmuştur.
Amacımız, misafirlerimize kaliteli, hızlı ve ekonomik yemek deneyimi sunmaktır.

Yenilikçi otomasyon sistemimiz ile:
• Siparişler, rezervasyonlar ve kampanyalar dijital olarak yönetilir.
• Müşteri memnuniyeti, hijyen ve lezzet önceliğimizdir.
• Sorularınız için 'Yardım' bölümünü kullanabilirsiniz.

Her gün sizin için daha iyisini hedefliyoruz!
Bizi tercih ettiğiniz için teşekkürler.";

            this.lblInfo.AutoSize = false;

            // UserControl
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.Controls.Add(this.pnlMain);
            this.Size = new System.Drawing.Size(750, 460);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
    }
}
