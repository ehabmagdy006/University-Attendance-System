namespace University_Attendance_System
{
    partial class AdminDashboard
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
            lblTitle = new Label();
            btnManageStudents = new Button();
            btnLogout = new Button();
            btnManageDoctors = new Button();
            pnlHeader = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(45, 94);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(203, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Dashboard";
            // 
            // btnManageStudents
            // 
            btnManageStudents.BackColor = SystemColors.ControlLightLight;
            btnManageStudents.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageStudents.ForeColor = SystemColors.Highlight;
            btnManageStudents.Location = new Point(132, 178);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(192, 105);
            btnManageStudents.TabIndex = 7;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = false;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.HighlightText;
            btnLogout.Location = new Point(671, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageDoctors
            // 
            btnManageDoctors.BackColor = SystemColors.ControlLightLight;
            btnManageDoctors.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageDoctors.ForeColor = SystemColors.Highlight;
            btnManageDoctors.Location = new Point(453, 178);
            btnManageDoctors.Name = "btnManageDoctors";
            btnManageDoctors.Size = new Size(192, 105);
            btnManageDoctors.TabIndex = 6;
            btnManageDoctors.Text = "Manage Doctors";
            btnManageDoctors.UseVisualStyleBackColor = false;
            btnManageDoctors.Click += btnManageDoctors_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Highlight;
            pnlHeader.Controls.Add(label2);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 73);
            pnlHeader.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(524, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 38);
            label2.TabIndex = 1;
            label2.Text = "Admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(466, 38);
            label1.TabIndex = 0;
            label1.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlHeader);
            Controls.Add(btnManageDoctors);
            Controls.Add(btnManageStudents);
            Controls.Add(lblTitle);
            Cursor = Cursors.Hand;
            Name = "AdminDashboard";
            Text = "Admin Dashboard";
            Load += DoctorDashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnManageStudents;
        private Button btnLogout;
        private Button btnManageDoctors;
        private Panel pnlHeader;
        private Label label1;
        private Label label2;
    }
}