using System.Drawing.Drawing2D;

namespace University_Attendance_System
{
    public partial class AttendanceStatisticsForm : Form
    {
        private int _total, _present, _absent;
        private double _rate;
        private float _progress;
        private readonly System.Windows.Forms.Timer _anim = new() { Interval = 15 };

        public AttendanceStatisticsForm()
        {
            InitializeComponent();
            Gfx.MakeTransparent(lblnameattend, lblnameattend1);

            _anim.Tick += Anim_Tick;
            FormClosed += (s, e) => _anim.Dispose();
        }

        private void AttendanceStatisticsForm_Load(object sender, EventArgs e)
        {
            var (total, present, absent) = AttendanceData.Summary(AttendanceData.Create());
            _total = total;
            _present = present;
            _absent = absent;
            _rate = total == 0 ? 0 : present * 100.0 / total;

            txttotal.Text = _total.ToString();
            txtperesnt.Text = _present.ToString();
            txtabsent.Text = _absent.ToString();
            txtrate.Text = $"{_rate:F1}%";

            foreach (var t in new[] { txttotal, txtperesnt, txtabsent, txtrate })
            {
                t.ReadOnly = true;
                t.TextAlign = HorizontalAlignment.Center;
            }

            txtrate.ForeColor = _rate >= 75 ? Color.SeaGreen : _rate >= 60 ? Color.DarkOrange : Color.Firebrick;

            lbltrue.Text = "Present :";
            lblfalse.Text = "Absent :";

            _progress = 0;
            _anim.Start();
        }

        private void Anim_Tick(object? sender, EventArgs e)
        {
            _progress += 0.04f;
            if (_progress >= 1f)
            {
                _progress = 1f;
                _anim.Stop();
            }
            panel3.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) => Gfx.PaintHeader(sender, e);

        private void panel3_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            float t = 1f - (float)Math.Pow(1 - _progress, 3);
            float presentRatio = _total == 0 ? 0 : (float)_present / _total;
            float absentRatio = _total == 0 ? 0 : (float)_absent / _total;

            DrawBar(g, new Rectangle(70, 25, 400, 28), presentRatio * t,
                    Color.FromArgb(46, 139, 87), Color.FromArgb(144, 238, 144), $"{_present} / {_total}");
            DrawBar(g, new Rectangle(70, 74, 400, 28), absentRatio * t,
                    Color.FromArgb(178, 34, 34), Color.FromArgb(250, 128, 114), $"{_absent} / {_total}");

            DrawDonut(g, new Rectangle(520, 11, 100, 100), t);
        }

        private static void DrawBar(Graphics g, Rectangle track, float ratio, Color c1, Color c2, string caption)
        {
            using (var path = RoundedRect(track, 8))
            using (var bg = new SolidBrush(Color.FromArgb(230, 230, 230)))
                g.FillPath(bg, path);

            int w = (int)(track.Width * Math.Clamp(ratio, 0f, 1f));
            if (w > 2)
            {
                var fill = new Rectangle(track.X, track.Y, w, track.Height);
                using var path = RoundedRect(fill, 8);
                using var brush = new LinearGradientBrush(fill, c1, c2, LinearGradientMode.Horizontal);
                g.FillPath(brush, path);
            }

            using var font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(caption, font, Brushes.Black, track, sf);
        }

        private void DrawDonut(Graphics g, Rectangle r, float t)
        {
            var ring = Rectangle.Inflate(r, -8, -8);
            using var absentPen = new Pen(Color.FromArgb(178, 34, 34), 16);
            using var presentPen = new Pen(Color.FromArgb(46, 139, 87), 16);

            g.DrawEllipse(absentPen, ring);

            if (_total > 0 && _present > 0)
            {
                float sweep = 360f * _present / _total * t;
                g.DrawArc(presentPen, ring, -90, sweep);
            }

            using var font = new Font("Segoe UI", 12F, FontStyle.Bold);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString($"{_rate * t:F0}%", font, Brushes.Black, r, sf);
        }

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = Math.Min(radius * 2, Math.Min(r.Width, r.Height));
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void btnBack_Click_1(object sender, EventArgs e) => Close();
        private void summarygroup_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void lblabsent_Click(object sender, EventArgs e) { }
    }
}
