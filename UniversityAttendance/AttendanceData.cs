using System.Data;

namespace University_Attendance_System
{
    internal static class AttendanceData
    {
        public static DataTable Create()
        {
            var t = new DataTable();
            t.Columns.Add("Date", typeof(string));
            t.Columns.Add("Course", typeof(string));
            t.Columns.Add("Status", typeof(string));

            t.Rows.Add("2026-10-05", "Programming", "Present");
            t.Rows.Add("2026-10-12", "Programming", "Present");
            t.Rows.Add("2026-10-19", "Programming", "Absent");
            t.Rows.Add("2026-10-26", "Programming", "Present");
            t.Rows.Add("2026-11-02", "Programming", "Present");
            t.Rows.Add("2026-11-09", "Programming", "Absent");
            return t;
        }

        public static (int Total, int Present, int Absent) Summary(DataTable t)
        {
            int present = t.AsEnumerable().Count(r => r.Field<string>("Status") == "Present");
            int total = t.Rows.Count;
            return (total, present, total - present);
        }
    }
}
