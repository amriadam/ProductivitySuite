using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.Views.Controls
{
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            path.AddArc(ClientRectangle.Left, ClientRectangle.Top, 6, 6, 180, 90); // Top left corner
            path.AddArc(ClientRectangle.Right - 6, ClientRectangle.Top, 6, 6, 270, 90); // Top right corner
            path.AddArc(ClientRectangle.Right - 6, ClientRectangle.Bottom - 6, 6, 6, 0, 90); // Bottom right corner
            path.AddArc(ClientRectangle.Left, ClientRectangle.Bottom - 6, 6, 6, 90, 90); // Bottom left corner
            path.CloseFigure();

            // Fill the rounded rectangle with the background color
            e.Graphics.FillPath(Brushes.White, path);

            // Draw the border of the rounded rectangle
            using (Pen pen = new Pen(Color.Black))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
