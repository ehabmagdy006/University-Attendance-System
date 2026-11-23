using System.Data;

namespace University_Attendance_System
{
    internal static class StudentRoster
    {
        public static DataTable Create()
        {
            var t = new DataTable();
            t.Columns.Add("ID", typeof(string));
            t.Columns.Add("Name", typeof(string));
            t.Columns.Add("Group", typeof(string));

            t.Rows.Add("200058690", "Ehab Magdy", "G1");
            t.Rows.Add("200062107", "Ahmed Faisal", "G1");
            t.Rows.Add("200062333", "Ahmed Gamal", "G1");
            t.Rows.Add("200060001", "Omar Hassan", "G2");
            t.Rows.Add("200060002", "Sara Ali", "G3");
            return t;
        }
    }
}
