using System;
using System.Windows.Forms;

namespace RestaurantOtomasyonuLive
{
    public partial class AboutUserControl : UserControl
    {
        public AboutUserControl()
        {
            InitializeComponent();
            CenterPanel();
            this.Resize += (s, e) => CenterPanel();
        }

        private void CenterPanel()
        {
            // Paneli her zaman ortala
            int parentWidth = this.Width;
            int parentHeight = this.Height;
            int panelWidth = pnlMain.Width;
            int panelHeight = pnlMain.Height;
            pnlMain.Left = (parentWidth - panelWidth) / 2;
            pnlMain.Top = (parentHeight - panelHeight) / 2;
        }
    }
}
