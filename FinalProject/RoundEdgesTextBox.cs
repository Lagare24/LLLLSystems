using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class RoundEdgesTextBox : TextBox
    {
        private const int WM_PAINT = 0xF;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                using (var graphics = Graphics.FromHwnd(Handle))
                {
                    using (var pen = new Pen(Color.Black))
                    {
                        int borderRadius = 10; // Change this value to adjust the roundness
                        int borderWidth = 1; // Change this value to adjust the border width

                        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        graphics.DrawRoundRectangle(pen, ClientRectangle, borderRadius, borderWidth);
                    }
                }
            }
        }
    }

    public static class GraphicsExtensions
    {
        public static void DrawRoundRectangle(this Graphics graphics, Pen pen, Rectangle rectangle, int borderRadius, int borderWidth)
        {
            RectangleF rectF = new RectangleF(rectangle.X, rectangle.Y, rectangle.Width - 1, rectangle.Height - 1);
            float cornerRadius = borderRadius * 2.0f;

            using (GraphicsPath path = new GraphicsPath())
            {
                // Top left arc
                path.AddArc(rectF.X, rectF.Y, cornerRadius, cornerRadius, 180, 90);

                // Top right arc
                path.AddArc(rectF.X + rectF.Width - cornerRadius, rectF.Y, cornerRadius, cornerRadius, 270, 90);

                // Bottom right arc
                path.AddArc(rectF.X + rectF.Width - cornerRadius, rectF.Y + rectF.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);

                // Bottom left arc
                path.AddArc(rectF.X, rectF.Y + rectF.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

                // Close the path
                path.CloseFigure();

                // Draw the path
                graphics.DrawPath(pen, path);
            }
        }
    }
}
