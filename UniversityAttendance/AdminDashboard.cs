namespace University_Attendance_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            Nav.Push(this, new ManageStudentsForm());
        }

        private void btnManageDoctors_Click(object sender, EventArgs e)
        {
            Nav.Push(this, new ManageDoctorsForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Nav.Logout(this);
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
        }
    }
}
