using System.Data;

namespace University_Attendance_System
{
    public partial class MarkAttendance : Form
    {
        private readonly DataTable roster = StudentRoster.Create();

        public MarkAttendance()
        {
            InitializeComponent();
            panel1.Paint += Gfx.PaintHeader;
            Gfx.MakeTransparent(label3, label4);
            button1.Click += (s, e) => Nav.Logout(this);
            button2.Click += btnSave_Click;
            Nav.AddBackButton(this, button1);
        }

        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            roster.Columns.Add("Status", typeof(string));
            foreach (DataRow row in roster.Rows)
                row["Status"] = "Present";

            dtpDate.MaxDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;

            SetupGrid();
            comboBox4.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            dgvAttendance.AutoGenerateColumns = false;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Highlight;
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dgvAttendance.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvAttendance.RowTemplate.Height = 34;

            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                DataPropertyName = "ID",
                HeaderText = "Student's ID",
                ReadOnly = true
            });
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Student",
                ReadOnly = true
            });
            dgvAttendance.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Group",
                DataPropertyName = "Group",
                HeaderText = "Group",
                ReadOnly = true
            });

            var status = new DataGridViewComboBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Attendance Status",
                FlatStyle = FlatStyle.Flat
            };
            status.Items.AddRange("Present", "Absent");
            dgvAttendance.Columns.Add(status);

            dgvAttendance.DataSource = roster.DefaultView;

            dgvAttendance.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvAttendance.IsCurrentCellDirty)
                    dgvAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvAttendance.CellFormatting += dgvAttendance_CellFormatting;
        }

        private void dgvAttendance_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAttendance.Columns[e.ColumnIndex].Name != "Status") return;

            e.CellStyle.ForeColor = Convert.ToString(e.Value) == "Absent" ? Color.Firebrick : Color.SeaGreen;
        }

        private void comboBox4_SelectedIndexChanged(object? sender, EventArgs e)
        {
            roster.DefaultView.RowFilter = $"[Group] = '{comboBox4.Text}'";
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a group", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int present = 0, absent = 0;
            foreach (DataRowView row in roster.DefaultView)
            {
                if (Convert.ToString(row["Status"]) == "Present") present++;
                else absent++;
            }

            MessageBox.Show(
                $"Attendance saved for group {comboBox4.Text} on {dtpDate.Value:yyyy-MM-dd}.\nPresent: {present}\nAbsent: {absent}",
                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
