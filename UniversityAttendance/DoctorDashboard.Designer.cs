namespace University_Attendance_System
{
    partial class DoctorDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            panel4 = new Panel();
            linkLabel3 = new LinkLabel();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(66, 114);
            label1.Name = "label1";
            label1.Size = new Size(275, 68);
            label1.TabIndex = 0;
            label1.Text = "Doctor Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(32, 197);
            label2.Name = "label2";
            label2.Size = new Size(513, 48);
            label2.TabIndex = 1;
            label2.Text = "View assigned classes ,record attendance";
            label2.Click += label2_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 93);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new Point(31, 27);
            label4.Name = "label4";
            label4.Size = new Size(466, 38);
            label4.TabIndex = 4;
            label4.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new Point(606, 27);
            label3.Name = "label3";
            label3.Size = new Size(101, 38);
            label3.TabIndex = 3;
            label3.Text = "Doctor";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(29, 327);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 133);
            panel2.TabIndex = 4;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(91, 75);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(130, 25);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Open Page ->";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(3, 21);
            label5.Name = "label5";
            label5.Size = new Size(323, 41);
            label5.TabIndex = 0;
            label5.Text = "My Students / Classes";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(513, 327);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 133);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(94, 95);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 25);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Open Page ->";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(20, 21);
            label6.Name = "label6";
            label6.Size = new Size(249, 99);
            label6.TabIndex = 0;
            label6.Text = "            Mark                Attendance";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(linkLabel3);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(25, 524);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(335, 133);
            panel4.TabIndex = 6;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.Location = new Point(91, 76);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(130, 25);
            linkLabel3.TabIndex = 1;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Open Page ->";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.HotTrack;
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(313, 41);
            label7.TabIndex = 0;
            label7.Text = "Attendance Statistics";
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(949, 803);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DoctorDashboard";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
        private Label label7;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
    }
}
