namespace University_Attendance_System
{
    public partial class ManageDoctorsForm : Form
    {
        public ManageDoctorsForm()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ManageDoctorsForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDoctorID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Doctor ID");
                return;
            }

            foreach (DataGridViewRow r in dgvDoctors.Rows)
            {
                if (!r.IsNewRow && Convert.ToString(r.Cells[0].Value) == id.ToString())
                {
                    MessageBox.Show("This Doctor ID already exists");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtDoctorName.Text))
            {
                MessageBox.Show("Please enter Doctor Name");
                return;
            }

            if (!txtDoctorEmail.Text.Contains('@') ||
                !txtDoctorEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please enter a valid Email");
                return;
            }

            if (cmbDepartment.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtSpecialization.Text))
            {
                MessageBox.Show("Please select Department and enter Specialization");
                return;
            }

            Doctor doctor = new Doctor();

            doctor.ID = id;
            doctor.Name = txtDoctorName.Text;
            doctor.Email = txtDoctorEmail.Text;
            doctor.Department = cmbDepartment.Text;
            doctor.Specialization = txtSpecialization.Text;

            dgvDoctors.Rows.Add(
                doctor.ID,
                doctor.Name,
                doctor.Email,
                doctor.Department,
                doctor.Specialization
            );

            MessageBox.Show("Doctor Object Created Successfully");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor first");
                return;
            }

            DataGridViewRow row = dgvDoctors.SelectedRows[0];

            if (!int.TryParse(txtDoctorID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Doctor ID");
                return;
            }

            row.Cells[0].Value = txtDoctorID.Text;
            row.Cells[1].Value = txtDoctorName.Text;
            row.Cells[2].Value = txtDoctorEmail.Text;
            row.Cells[3].Value = cmbDepartment.Text;
            row.Cells[4].Value = txtSpecialization.Text;

            MessageBox.Show("Doctor Updated Successfully");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDoctorID.Clear();
            txtDoctorName.Clear();
            txtDoctorEmail.Clear();
            cmbDepartment.SelectedIndex = -1;
            txtSpecialization.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor first");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this doctor?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                dgvDoctors.Rows.RemoveAt(
                    dgvDoctors.SelectedRows[0].Index
                );

                MessageBox.Show("Doctor Deleted Successfully");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearch.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Doctor ID");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in dgvDoctors.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (Convert.ToString(row.Cells[0].Value) == id.ToString())
                {
                    row.Selected = true;
                    dgvDoctors.CurrentCell = row.Cells[0];

                    txtDoctorID.Text = row.Cells[0].Value.ToString();
                    txtDoctorName.Text = row.Cells[1].Value.ToString();
                    txtDoctorEmail.Text = row.Cells[2].Value.ToString();
                    cmbDepartment.Text = row.Cells[3].Value.ToString();
                    txtSpecialization.Text = row.Cells[4].Value.ToString();

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Doctor Not Found");
            }
        }
        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvDoctors.Rows[e.RowIndex];

            txtDoctorID.Text = row.Cells[0].Value.ToString();
            txtDoctorName.Text = row.Cells[1].Value.ToString();
            txtDoctorEmail.Text = row.Cells[2].Value.ToString();
            cmbDepartment.Text = row.Cells[3].Value.ToString();
            txtSpecialization.Text = row.Cells[4].Value.ToString();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}