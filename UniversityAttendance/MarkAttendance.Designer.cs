namespace University_Attendance_System
{
    partial class MarkAttendance
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label13 = new Label();
            label14 = new Label();
            comboBox4 = new ComboBox();
            dgvAttendance = new DataGridView();
            dtpDate = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 93);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(23, 27);
            label4.Name = "label4";
            label4.Size = new Size(466, 38);
            label4.TabIndex = 4;
            label4.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(591, 27);
            label3.Name = "label3";
            label3.Size = new Size(101, 38);
            label3.TabIndex = 3;
            label3.Text = "Doctor";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(798, 27);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(320, 87);
            label1.TabIndex = 9;
            label1.Text = "Mark Attendance";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(115, 609);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(141, 48);
            button2.TabIndex = 10;
            button2.Text = "SAVE";
            button2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ControlLight;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(115, 184);
            label13.Name = "label13";
            label13.Size = new Size(113, 23);
            label13.TabIndex = 11;
            label13.Text = "Class / Group";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlLight;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(553, 184);
            label14.Name = "label14";
            label14.Size = new Size(107, 23);
            label14.TabIndex = 12;
            label14.Text = "Lecture Date";
            // 
            // comboBox4
            // 
            comboBox4.BackColor = SystemColors.Info;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "G1", "G2", "G3" });
            comboBox4.Location = new Point(105, 222);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(162, 28);
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            comboBox4.TabIndex = 16;
            // 
            // dgvAttendance
            // 
            dgvAttendance.Location = new Point(38, 284);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(840, 300);
            dgvAttendance.TabIndex = 7;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy / MM / dd";
            dtpDate.Location = new Point(493, 220);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(216, 27);
            dtpDate.TabIndex = 8;
            // 
            // MarkAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 673);
            Controls.Add(comboBox4);
            Controls.Add(dtpDate);
            Controls.Add(dgvAttendance);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MarkAttendance";
            Text = "Mark Attendance";
            Load += MarkAttendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label1;
        private Button button2;
        private Label label13;
        private Label label14;
        private ComboBox comboBox4;
        private DataGridView dgvAttendance;
        private DateTimePicker dtpDate;
    }
}