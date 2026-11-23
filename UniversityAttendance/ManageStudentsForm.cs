using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Attendance_System
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Student ID");
                return;
            }

            foreach (DataGridViewRow r in dgvStudents.Rows)
            {
                if (!r.IsNewRow && Convert.ToString(r.Cells[0].Value) == id.ToString())
                {
                    MessageBox.Show("This Student ID already exists");
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter Student Name");
                return;
            }

            if (!txtEmail.Text.Contains('@') ||
                !txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please enter a valid Email");
                return;
            }

            if (cmbDepartment.SelectedIndex == -1 ||
               cmbYear.SelectedIndex == -1 ||
               cmbSubject.SelectedIndex == -1
           )
            {
                MessageBox.Show("Please select Department | Subject | Academic Year");
                return;
            }

            Student student = new Student();

            student.StudentID = id;
            student.StudentName = txtStudentName.Text;
            student.Email = txtEmail.Text;
            student.Department = cmbDepartment.Text;
            student.AcademicYear = cmbYear.Text;
            student.Subject = cmbSubject.Text;

            dgvStudents.Rows.Add(
                student.StudentID,
                student.StudentName,
                student.Email,
                student.Department,
                student.AcademicYear,
                student.Subject
            );

            MessageBox.Show("Student Object Created Successfully");
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first");
                return;
            }
            DataGridViewRow row = dgvStudents.SelectedRows[0];

            if (!int.TryParse(txtStudentID.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Student ID");
                return;
            }

            row.Cells[0].Value = txtStudentID.Text;
            row.Cells[1].Value = txtStudentName.Text;
            row.Cells[2].Value = txtEmail.Text;
            row.Cells[3].Value = cmbDepartment.Text;
            row.Cells[4].Value = cmbYear.Text;
            row.Cells[5].Value = cmbSubject.Text;
            MessageBox.Show("Student Updated Successfully");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtEmail.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
        }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtStudentName.Text = row.Cells[1].Value.ToString();
            txtEmail.Text = row.Cells[2].Value.ToString();
            cmbDepartment.Text = row.Cells[3].Value.ToString();
            cmbYear.Text = row.Cells[4].Value.ToString();
            cmbSubject.Text = row.Cells[5].Value.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student first");
                return;
            }

            DialogResult result = MessageBox.Show(

                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                dgvStudents.Rows.RemoveAt(
                    dgvStudents.SelectedRows[0].Index
                    );
                MessageBox.Show("Student Deleted Successfully");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearch.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Student ID");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (Convert.ToString(row.Cells[0].Value) == id.ToString())
                {
                    row.Selected = true;
                    dgvStudents.CurrentCell = row.Cells[0];

                    txtStudentID.Text = row.Cells[0].Value.ToString();
                    txtStudentName.Text = row.Cells[1].Value.ToString();
                    txtEmail.Text = row.Cells[2].Value.ToString();
                    cmbDepartment.Text = row.Cells[3].Value.ToString();
                    cmbYear.Text = row.Cells[4].Value.ToString();
                    cmbSubject.Text = row.Cells[5].Value.ToString();

                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Student Not Found");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}