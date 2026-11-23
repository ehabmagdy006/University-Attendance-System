using System.Data;

namespace University_Attendance_System
{
    public partial class AssignedStudents : Form
    {
        private readonly DataTable students = StudentRoster.Create();

        public AssignedStudents()
        {
            InitializeComponent();
            panel1.Paint += Gfx.PaintHeader;
            Gfx.MakeTransparent(label3, label4);
            button1.Click += (s, e) => Nav.Logout(this);
            Nav.AddBackButton(this, button1);
        }

        private void AssignedStudents_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = students.DefaultView;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.MultiSelect = false;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Highlight;
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvStudents.RowTemplate.Height = 34;

            dgvStudents.Columns["ID"]!.HeaderText = "Student's ID";
            dgvStudents.Columns["Name"]!.HeaderText = "Student";
            dgvStudents.Columns["Group"]!.HeaderText = "Group";
        }

        private void textBox1_TextChanged(object sender, EventArgs e) => FilterStudents(false);

        private void button2_Click(object sender, EventArgs e) => FilterStudents(true);

        private void FilterStudents(bool showMessages)
        {
            string text = textBox1.Text.Trim();

            if (text.Length > 0 && !text.All(char.IsDigit))
            {
                if (showMessages)
                    MessageBox.Show("Please enter a valid Student ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            students.DefaultView.RowFilter = text.Length == 0 ? "" : $"ID LIKE '{text}%'";

            if (showMessages && students.DefaultView.Count == 0)
                MessageBox.Show("Student Not Found");
        }
    }
}
