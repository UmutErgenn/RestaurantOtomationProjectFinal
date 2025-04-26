using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RestaurantOtomasyonuLive
{
    internal class Notification
    {
        public void showNotification(Form ownerForm, string message, bool isError)
        {
            Form notificationForm = new Form();
            notificationForm.FormBorderStyle = FormBorderStyle.None;
            notificationForm.StartPosition = FormStartPosition.Manual;
            notificationForm.BackColor = Color.Black; // Arka plan siyah
            notificationForm.Size = new Size(300, 50);
            notificationForm.TopMost = true;

            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Burada yazı rengini duruma göre ayarlıyoruz
            lblMessage.ForeColor = isError ? Color.Red : Color.WhiteSmoke;

            notificationForm.Controls.Add(lblMessage);

            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(notificationForm.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(notificationForm.Width - radius, notificationForm.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, notificationForm.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            notificationForm.Region = new Region(path);

            int x = ownerForm.Left + (ownerForm.Width / 2) - (notificationForm.Width / 2);
            int y = ownerForm.Top + 20;
            notificationForm.Location = new Point(x, y);

            notificationForm.Show();

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (s, e) =>
            {
                notificationForm.Close();
                timer.Stop();
            };
            timer.Start();
        }
    }
}
