namespace University_Attendance_System
{
    partial class StudentDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentdashboardgroup = new GroupBox();
            txtrole = new TextBox();
            lblrole = new Label();
            lbltext = new Label();
            menugroup = new GroupBox();
            btnMyAttendance = new Button();
            btnMyStatistics = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            lblnamedashboard1 = new Label();
            lblnamedashboard = new Label();
            studentdashboardgroup.SuspendLayout();
            menugroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentdashboardgroup
            // 
            studentdashboardgroup.Controls.Add(txtrole);
            studentdashboardgroup.Controls.Add(lblrole);
            studentdashboardgroup.Controls.Add(lbltext);
            studentdashboardgroup.Location = new Point(45, 157);
            studentdashboardgroup.Name = "studentdashboardgroup";
            studentdashboardgroup.Size = new Size(737, 93);
            studentdashboardgroup.TabIndex = 0;
            studentdashboardgroup.TabStop = false;
            studentdashboardgroup.Text = "Student Dashboard";
            // 
            // txtrole
            // 
            txtrole.Location = new Point(68, 54);
            txtrole.Name = "txtrole";
            txtrole.Size = new Size(217, 27);
            txtrole.TabIndex = 2;
            txtrole.Text = "20000000";
            // 
            // lblrole
            // 
            lblrole.AutoSize = true;
            lblrole.Location = new Point(6, 54);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(31, 20);
            lblrole.TabIndex = 0;
            lblrole.Text = "ID :";
            lblrole.Click += lblrole_Click;
            // 
            // lbltext
            // 
            lbltext.AutoSize = true;
            lbltext.Location = new Point(6, 23);
            lbltext.Name = "lbltext";
            lbltext.Size = new Size(421, 40);
            lbltext.TabIndex = 1;
            lbltext.Text = "View your own attendance record and attendance percentage!\r\n.";
            lbltext.Click += label2_Click;
            // 
            // menugroup
            // 
            menugroup.Controls.Add(btnMyAttendance);
            menugroup.Controls.Add(btnMyStatistics);
            menugroup.Location = new Point(45, 282);
            menugroup.Name = "menugroup";
            menugroup.Size = new Size(737, 193);
            menugroup.TabIndex = 0;
            menugroup.TabStop = false;
            menugroup.Text = "Menu";
            // 
            // btnMyAttendance
            // 
            btnMyAttendance.BackColor = SystemColors.ControlLightLight;
            btnMyAttendance.Location = new Point(400, 57);
            btnMyAttendance.Name = "btnMyAttendance";
            btnMyAttendance.Size = new Size(307, 70);
            btnMyAttendance.TabIndex = 3;
            btnMyAttendance.Text = "My Attendance";
            btnMyAttendance.UseVisualStyleBackColor = false;
            btnMyAttendance.Click += BtnMyAttendance_Click;
            // 
            // btnMyStatistics
            // 
            btnMyStatistics.BackColor = SystemColors.ControlLightLight;
            btnMyStatistics.ForeColor = SystemColors.ControlText;
            btnMyStatistics.Location = new Point(31, 57);
            btnMyStatistics.Name = "btnMyStatistics";
            btnMyStatistics.Size = new Size(307, 70);
            btnMyStatistics.TabIndex = 4;
            btnMyStatistics.Text = "My Statistics";
            btnMyStatistics.UseVisualStyleBackColor = false;
            btnMyStatistics.Click += btnMyStatistics_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Snow;
            btnLogout.Location = new Point(735, 498);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(162, 54);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblnamedashboard1);
            panel1.Controls.Add(lblnamedashboard);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 96);
            panel1.TabIndex = 10;
            // 
            // lblnamedashboard1
            // 
            lblnamedashboard1.AutoSize = true;
            lblnamedashboard1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnamedashboard1.ForeColor = SystemColors.ButtonFace;
            lblnamedashboard1.Location = new Point(659, 29);
            lblnamedashboard1.Name = "lblnamedashboard1";
            lblnamedashboard1.Size = new Size(121, 41);
            lblnamedashboard1.TabIndex = 2;
            lblnamedashboard1.Text = "Student";
            // 
            // lblnamedashboard
            // 
            lblnamedashboard.AutoSize = true;
            lblnamedashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnamedashboard.ForeColor = SystemColors.ButtonFace;
            lblnamedashboard.Location = new Point(43, 29);
            lblnamedashboard.Name = "lblnamedashboard";
            lblnamedashboard.Size = new Size(499, 41);
            lblnamedashboard.TabIndex = 3;
            lblnamedashboard.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 564);
            Controls.Add(panel1);
            Controls.Add(menugroup);
            Controls.Add(btnLogout);
            Controls.Add(studentdashboardgroup);
            Name = "StudentDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboardForm";
            studentdashboardgroup.ResumeLayout(false);
            studentdashboardgroup.PerformLayout();
            menugroup.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblrole_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox studentdashboardgroup;
        private GroupBox menugroup;
        private Label lblrole;
        private Label lbltext;
        private TextBox txtrole;
        private Button btnMyAttendance;
        private Button btnMyStatistics;
        private Button btnLogout;
        private Panel panel1;
        private Label lblnamedashboard1;
        private Label lblnamedashboard;
    }
}