namespace University_Attendance_System
{
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
            panel1.Paint += Gfx.PaintHeader;
            Gfx.MakeTransparent(lblnamedashboard, lblnamedashboard1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Nav.Logout(this);
        }

        private void btnMyStatistics_Click(object sender, EventArgs e)
        {
            Nav.Push(this, new AttendanceStatisticsForm());
        }

        private void BtnMyAttendance_Click(object sender, EventArgs e)
        {
            Nav.Push(this, new MyAttendanceForm());
        }
    }
}
