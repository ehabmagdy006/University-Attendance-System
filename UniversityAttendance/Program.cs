namespace University_Attendance_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Nav.Open(new LoginForm());
            Application.Run(new ApplicationContext());
        }
    }
}
