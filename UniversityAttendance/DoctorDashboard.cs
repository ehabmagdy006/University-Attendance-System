namespace University_Attendance_System
{
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
            panel1.Paint += Gfx.PaintHeader;
            Gfx.MakeTransparent(label3, label4);
            button1.Click += (s, e) => Nav.Logout(this);
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nav.Push(this, new AssignedStudents());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Nav.Push(this, new MarkAttendance());
        }

        private void linkLabel3_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Nav.Push(this, new AttendanceStatisticsForm());
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
