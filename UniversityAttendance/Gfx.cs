using System.Drawing.Drawing2D;

namespace University_Attendance_System
{
    internal class BufferedPanel : Panel
    {
        public BufferedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }

    internal static class Gfx
    {
        public static void PaintHeader(object? sender, PaintEventArgs e)
        {
            if (sender is not Control c || c.Width == 0 || c.Height == 0) return;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new LinearGradientBrush(
                c.ClientRectangle,
                Color.FromArgb(0, 70, 160),
                Color.FromArgb(70, 150, 230),
                LinearGradientMode.Horizontal))
            {
                g.FillRectangle(brush, c.ClientRectangle);
            }

            using var pen = new Pen(Color.FromArgb(160, Color.White), 2);
            g.DrawLine(pen, 0, c.Height - 2, c.Width, c.Height - 2);
        }

        public static void MakeTransparent(params Control[] controls)
        {
            foreach (var c in controls) c.BackColor = Color.Transparent;
        }
    }
}
