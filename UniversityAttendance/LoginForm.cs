namespace University_Attendance_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter username and password.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            Form? next = null;

            if (IsMatch(username, password, "admin@gmail.com", "123"))
                next = new AdminDashboard();
            else if (IsMatch(username, password, "doctor@gmail.com", "123"))
                next = new DoctorDashboard();
            else if (IsMatch(username, password, "student@gmail.com", "123"))
                next = new StudentDashboardForm();

            if (next == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nav.Open(next);
            this.Close();
        }

        private static bool IsMatch(string user, string pass, string expectedUser, string expectedPass)
        {
            return string.Equals(user, expectedUser, StringComparison.OrdinalIgnoreCase) && pass == expectedPass;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
