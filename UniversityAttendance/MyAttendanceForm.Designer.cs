namespace University_Attendance_System
{
    partial class MyAttendanceForm
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
            filtergroup = new GroupBox();
            btnFilter = new Button();
            lblstatus = new Label();
            boxstatus = new ComboBox();
            lblcourse = new Label();
            boxcourse = new ComboBox();
            btnBack = new Button();
            MyAttendancegroup = new GroupBox();
            attendancedata = new DataGridView();
            panel2 = new Panel();
            lblnamefilter1 = new Label();
            lblnamefilter = new Label();
            filtergroup.SuspendLayout();
            MyAttendancegroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendancedata).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // filtergroup
            // 
            filtergroup.Controls.Add(btnFilter);
            filtergroup.Controls.Add(lblstatus);
            filtergroup.Controls.Add(boxstatus);
            filtergroup.Controls.Add(lblcourse);
            filtergroup.Controls.Add(boxcourse);
            filtergroup.Location = new Point(44, 119);
            filtergroup.Name = "filtergroup";
            filtergroup.Size = new Size(758, 91);
            filtergroup.TabIndex = 0;
            filtergroup.TabStop = false;
            filtergroup.Text = "Filter";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(589, 27);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(163, 35);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(316, 35);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(49, 20);
            lblstatus.TabIndex = 7;
            lblstatus.Text = "Status";
            // 
            // boxstatus
            // 
            boxstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            boxstatus.FormattingEnabled = true;
            boxstatus.Location = new Point(371, 31);
            boxstatus.Name = "boxstatus";
            boxstatus.Size = new Size(183, 28);
            boxstatus.TabIndex = 2;
            // 
            // lblcourse
            // 
            lblcourse.AutoSize = true;
            lblcourse.Location = new Point(20, 35);
            lblcourse.Name = "lblcourse";
            lblcourse.Size = new Size(54, 20);
            lblcourse.TabIndex = 6;
            lblcourse.Text = "Course";
            // 
            // boxcourse
            // 
            boxcourse.DropDownStyle = ComboBoxStyle.DropDownList;
            boxcourse.FormattingEnabled = true;
            boxcourse.Items.AddRange(new object[] { "cs101", "cs102", "cs103" });
            boxcourse.Location = new Point(80, 35);
            boxcourse.Name = "boxcourse";
            boxcourse.Size = new Size(218, 28);
            boxcourse.TabIndex = 1;
            boxcourse.SelectedIndexChanged += boxcourse_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Snow;
            btnBack.Location = new Point(725, 468);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 40);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // MyAttendancegroup
            // 
            MyAttendancegroup.Controls.Add(attendancedata);
            MyAttendancegroup.Location = new Point(44, 236);
            MyAttendancegroup.Name = "MyAttendancegroup";
            MyAttendancegroup.Size = new Size(758, 209);
            MyAttendancegroup.TabIndex = 8;
            MyAttendancegroup.TabStop = false;
            MyAttendancegroup.Text = "My Attendance";
            // 
            // attendancedata
            // 
            attendancedata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendancedata.Location = new Point(144, 43);
            attendancedata.Name = "attendancedata";
            attendancedata.RowHeadersWidth = 51;
            attendancedata.Size = new Size(449, 142);
            attendancedata.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(lblnamefilter1);
            panel2.Controls.Add(lblnamefilter);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 96);
            panel2.TabIndex = 9;
            // 
            // lblnamefilter1
            // 
            lblnamefilter1.AutoSize = true;
            lblnamefilter1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnamefilter1.ForeColor = SystemColors.ButtonFace;
            lblnamefilter1.Location = new Point(680, 27);
            lblnamefilter1.Name = "lblnamefilter1";
            lblnamefilter1.Size = new Size(121, 41);
            lblnamefilter1.TabIndex = 2;
            lblnamefilter1.Text = "Student";
            // 
            // lblnamefilter
            // 
            lblnamefilter.AutoSize = true;
            lblnamefilter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnamefilter.ForeColor = SystemColors.ButtonFace;
            lblnamefilter.Location = new Point(43, 27);
            lblnamefilter.Name = "lblnamefilter";
            lblnamefilter.Size = new Size(499, 41);
            lblnamefilter.TabIndex = 3;
            lblnamefilter.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // MyAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 519);
            Controls.Add(panel2);
            Controls.Add(MyAttendancegroup);
            Controls.Add(btnBack);
            Controls.Add(filtergroup);
            Name = "MyAttendanceForm";
            Text = "MyAttendanceForm";
            Load += MyAttendanceForm_Load;
            filtergroup.ResumeLayout(false);
            filtergroup.PerformLayout();
            MyAttendancegroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendancedata).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox filtergroup;
        private Button btnFilter;
        private ComboBox boxstatus;
        private ComboBox boxcourse;
        private Button btnBack;
        private Label lblstatus;
        private Label lblcourse;
        private GroupBox MyAttendancegroup;
        private DataGridView attendancedata;
        private Panel panel2;
        private Label lblnamefilter1;
        private Label lblnamefilter;
    }
}