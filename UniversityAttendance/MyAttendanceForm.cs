using System.Data;

namespace University_Attendance_System
{
    public partial class MyAttendanceForm : Form
    {
        private DataTable attendanceTable = new();
        private Font? _boldFont;

        public MyAttendanceForm()
        {
            InitializeComponent();
            panel2.Paint += Gfx.PaintHeader;
            Gfx.MakeTransparent(lblnamefilter, lblnamefilter1);
        }

        private void MyAttendanceForm_Load(object sender, EventArgs e)
        {
            boxcourse.Items.Clear();
            boxcourse.Items.Add("All Courses");
            boxcourse.Items.Add("Programming");
            boxcourse.SelectedIndex = 0;

            boxstatus.Items.Clear();
            boxstatus.Items.Add("All");
            boxstatus.Items.Add("Present");
            boxstatus.Items.Add("Absent");
            boxstatus.SelectedIndex = 0;

            attendanceTable = AttendanceData.Create();
            attendancedata.DataSource = attendanceTable.DefaultView;
            attendancedata.CellFormatting += attendancedata_CellFormatting;
        }

        private void attendancedata_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || attendancedata.Columns[e.ColumnIndex].Name != "Status") return;

            string status = Convert.ToString(e.Value) ?? "";
            e.CellStyle.ForeColor = status == "Present" ? Color.SeaGreen : Color.Firebrick;
            _boldFont ??= new Font(attendancedata.Font, FontStyle.Bold);
            e.CellStyle.Font = _boldFont;
        }

        private void boxcourse_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private void btnFilter_Click(object sender, EventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            string? course = boxcourse.SelectedItem?.ToString();
            string? status = boxstatus.SelectedItem?.ToString();

            var parts = new List<string>();
            if (!string.IsNullOrEmpty(course) && course != "All Courses")
                parts.Add($"Course = '{course.Replace("'", "''")}'");
            if (!string.IsNullOrEmpty(status) && status != "All")
                parts.Add($"Status = '{status.Replace("'", "''")}'");

            attendanceTable.DefaultView.RowFilter = string.Join(" AND ", parts);
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();
    }
}
