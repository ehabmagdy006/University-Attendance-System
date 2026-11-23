namespace University_Attendance_System
{
    partial class AttendanceStatisticsForm
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
            summarygroup = new GroupBox();
            lbltotal = new Label();
            txttotal = new TextBox();
            txtrate = new TextBox();
            lblpresent = new Label();
            txtperesnt = new TextBox();
            txtabsent = new TextBox();
            lblrate = new Label();
            lblabsent = new Label();
            attendanceoverviewgroup = new GroupBox();
            lbltrue = new Label();
            lblfalse = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            lblnameattend1 = new Label();
            lblnameattend = new Label();
            panel3 = new BufferedPanel();
            summarygroup.SuspendLayout();
            attendanceoverviewgroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // summarygroup
            // 
            summarygroup.BackColor = Color.Transparent;
            summarygroup.Controls.Add(lbltotal);
            summarygroup.Controls.Add(txttotal);
            summarygroup.Controls.Add(txtrate);
            summarygroup.Controls.Add(lblpresent);
            summarygroup.Controls.Add(txtperesnt);
            summarygroup.Controls.Add(txtabsent);
            summarygroup.Controls.Add(lblrate);
            summarygroup.Controls.Add(lblabsent);
            summarygroup.Location = new Point(106, 120);
            summarygroup.Name = "summarygroup";
            summarygroup.Size = new Size(735, 181);
            summarygroup.TabIndex = 0;
            summarygroup.TabStop = false;
            summarygroup.Text = "Summary";
            summarygroup.Enter += summarygroup_Enter;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(6, 58);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(107, 20);
            lbltotal.TabIndex = 6;
            lbltotal.Text = "Total Lectures :";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(130, 51);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(188, 27);
            txttotal.TabIndex = 4;
            // 
            // txtrate
            // 
            txtrate.Location = new Point(506, 115);
            txtrate.Name = "txtrate";
            txtrate.Size = new Size(188, 27);
            txtrate.TabIndex = 1;
            // 
            // lblpresent
            // 
            lblpresent.AutoSize = true;
            lblpresent.Location = new Point(6, 122);
            lblpresent.Name = "lblpresent";
            lblpresent.Size = new Size(63, 20);
            lblpresent.TabIndex = 8;
            lblpresent.Text = "Present :";
            // 
            // txtperesnt
            // 
            txtperesnt.Location = new Point(130, 115);
            txtperesnt.Name = "txtperesnt";
            txtperesnt.Size = new Size(188, 27);
            txtperesnt.TabIndex = 2;
            // 
            // txtabsent
            // 
            txtabsent.Location = new Point(506, 44);
            txtabsent.Name = "txtabsent";
            txtabsent.Size = new Size(188, 27);
            txtabsent.TabIndex = 3;
            // 
            // lblrate
            // 
            lblrate.AutoSize = true;
            lblrate.Location = new Point(358, 122);
            lblrate.Name = "lblrate";
            lblrate.Size = new Size(126, 20);
            lblrate.TabIndex = 7;
            lblrate.Text = "Attendance Rate :";
            // 
            // lblabsent
            // 
            lblabsent.AutoSize = true;
            lblabsent.Location = new Point(358, 51);
            lblabsent.Name = "lblabsent";
            lblabsent.Size = new Size(62, 20);
            lblabsent.TabIndex = 5;
            lblabsent.Text = "Absent :";
            lblabsent.Click += lblabsent_Click;
            // 
            // attendanceoverviewgroup
            // 
            attendanceoverviewgroup.Controls.Add(panel3);
            attendanceoverviewgroup.Controls.Add(lbltrue);
            attendanceoverviewgroup.Controls.Add(lblfalse);
            attendanceoverviewgroup.Location = new Point(106, 318);
            attendanceoverviewgroup.Name = "attendanceoverviewgroup";
            attendanceoverviewgroup.Size = new Size(735, 149);
            attendanceoverviewgroup.TabIndex = 0;
            attendanceoverviewgroup.TabStop = false;
            attendanceoverviewgroup.Text = "Attendance Overview";
            // 
            // lbltrue
            // 
            lbltrue.AutoSize = true;
            lbltrue.Location = new Point(6, 49);
            lbltrue.Name = "lbltrue";
            lbltrue.Size = new Size(64, 20);
            lbltrue.TabIndex = 9;
            lbltrue.Text = "Present :";
            // 
            // lblfalse
            // 
            lblfalse.AutoSize = true;
            lblfalse.Location = new Point(6, 98);
            lblfalse.Name = "lblfalse";
            lblfalse.Size = new Size(62, 20);
            lblfalse.TabIndex = 10;
            lblfalse.Text = "Absent :";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Snow;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(834, 481);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 41);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(lblnameattend1);
            panel1.Controls.Add(lblnameattend);
            panel1.Location = new Point(-21, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1031, 104);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblnameattend1
            // 
            lblnameattend1.AutoSize = true;
            lblnameattend1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnameattend1.ForeColor = SystemColors.ButtonFace;
            lblnameattend1.Location = new Point(741, 36);
            lblnameattend1.Name = "lblnameattend1";
            lblnameattend1.Size = new Size(121, 41);
            lblnameattend1.TabIndex = 2;
            lblnameattend1.Text = "Student";
            // 
            // lblnameattend
            // 
            lblnameattend.AutoSize = true;
            lblnameattend.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnameattend.ForeColor = SystemColors.ButtonFace;
            lblnameattend.Location = new Point(127, 36);
            lblnameattend.Name = "lblnameattend";
            lblnameattend.Size = new Size(499, 41);
            lblnameattend.TabIndex = 3;
            lblnameattend.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            lblnameattend.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Location = new Point(80, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(650, 122);
            panel3.TabIndex = 14;
            panel3.Paint += panel3_Paint;
            // 
            // AttendanceStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 608);
            Controls.Add(panel1);
            Controls.Add(attendanceoverviewgroup);
            Controls.Add(btnBack);
            Controls.Add(summarygroup);
            Name = "AttendanceStatisticsForm";
            Text = "AttendanceStatisticsForm";
            Load += AttendanceStatisticsForm_Load;
            summarygroup.ResumeLayout(false);
            summarygroup.PerformLayout();
            attendanceoverviewgroup.ResumeLayout(false);
            attendanceoverviewgroup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox summarygroup;
        private Label lbltotal;
        private TextBox txttotal;
        private TextBox txtrate;
        private Label lblpresent;
        private TextBox txtperesnt;
        private TextBox txtabsent;
        private Label lblrate;
        private Label lblabsent;
        private GroupBox attendanceoverviewgroup;
        private Button btnBack;
        private Label lbltrue;
        private Label lblfalse;
        private Panel panel1;
        private Label lblnameattend1;
        private Label lblnameattend;
        private BufferedPanel panel3;
    }
}