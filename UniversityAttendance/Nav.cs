namespace University_Attendance_System
{
    internal static class Nav
    {
        public static void Open(Form form)
        {
            form.FormClosed += (s, e) =>
            {
                bool anyLeft = Application.OpenForms.Cast<Form>()
                    .Any(f => !ReferenceEquals(f, s) && !f.IsDisposed);
                if (!anyLeft) Application.ExitThread();
            };
            form.Show();
        }

        private static bool _loggingOut;

        public static void Push(Form parent, Form child)
        {
            child.FormClosed += (s, e) =>
            {
                if (!_loggingOut && !parent.IsDisposed) parent.Show();
            };
            Open(child);
            parent.Hide();
        }

        public static void Logout(Form current)
        {
            _loggingOut = true;
            var login = new LoginForm();
            Open(login);
            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!ReferenceEquals(f, login)) f.Close();
            }
            _loggingOut = false;
        }

        public static void AddBackButton(Form form, Button reference)
        {
            var back = new Button
            {
                Text = "Back",
                Size = reference.Size,
                Location = new Point(reference.Left - reference.Width - 8, reference.Top),
                BackColor = reference.BackColor,
                ForeColor = reference.ForeColor,
                FlatStyle = reference.FlatStyle,
                Font = reference.Font,
                UseVisualStyleBackColor = false
            };
            back.Click += (s, e) => form.Close();
            reference.Parent!.Controls.Add(back);
            back.BringToFront();
        }
    }
}
