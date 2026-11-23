namespace University_Attendance_System
{
    partial class ManageDoctorsForm
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label5 = new GroupBox();
            cmbDepartment = new ComboBox();
            txtSpecialization = new TextBox();
            txtDoctorEmail = new TextBox();
            txtDoctorName = new TextBox();
            txtDoctorID = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            dgvDoctors = new DataGridView();
            txtSearch = new TextBox();
            label7 = new Label();
            btnBack = new Button();
            colDoctorID = new DataGridViewTextBoxColumn();
            colDoctorName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colSpecialization = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(63, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(204, 318);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(430, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(557, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.Controls.Add(cmbDepartment);
            label5.Controls.Add(txtSpecialization);
            label5.Controls.Add(txtDoctorEmail);
            label5.Controls.Add(txtDoctorName);
            label5.Controls.Add(txtDoctorID);
            label5.Controls.Add(label6);
            label5.Controls.Add(label4);
            label5.Controls.Add(label3);
            label5.Controls.Add(label2);
            label5.Controls.Add(label1);
            label5.Location = new Point(57, 131);
            label5.Name = "label5";
            label5.Size = new Size(647, 168);
            label5.TabIndex = 4;
            label5.TabStop = false;
            label5.Text = "Doctor Information";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Computer Science", "Artifical Intelligence", "Information Systems" });
            cmbDepartment.Location = new Point(411, 87);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(161, 28);
            cmbDepartment.TabIndex = 9;
            // 
            // txtSpecialization
            // 
            txtSpecialization.Location = new Point(411, 133);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(161, 27);
            txtSpecialization.TabIndex = 8;
            // 
            // txtDoctorEmail
            // 
            txtDoctorEmail.Location = new Point(411, 32);
            txtDoctorEmail.Name = "txtDoctorEmail";
            txtDoctorEmail.PlaceholderText = "Enter your Email";
            txtDoctorEmail.Size = new Size(161, 27);
            txtDoctorEmail.TabIndex = 7;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Location = new Point(112, 115);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.PlaceholderText = "Enter your name";
            txtDoctorName.Size = new Size(144, 27);
            txtDoctorName.TabIndex = 6;
            // 
            // txtDoctorID
            // 
            txtDoctorID.Location = new Point(112, 35);
            txtDoctorID.Name = "txtDoctorID";
            txtDoctorID.PlaceholderText = "Enter your ID";
            txtDoctorID.Size = new Size(144, 27);
            txtDoctorID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 136);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 4;
            label6.Text = "Specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 90);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 35);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 115);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Doctor Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Doctor ID :";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(651, 364);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.BackgroundColor = SystemColors.ControlLightLight;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Columns.AddRange(new DataGridViewColumn[] { colDoctorID, colDoctorName, colEmail, colDepartment, colSpecialization });
            dgvDoctors.Location = new Point(57, 430);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(679, 175);
            dgvDoctors.TabIndex = 6;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            dgvDoctors.CellContentClick += dgvDoctors_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(124, 366);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search By ID";
            txtSearch.Size = new Size(505, 27);
            txtSearch.TabIndex = 7;
            txtSearch.Click += txtSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 396);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 8;
            label7.Text = "Doctor List";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(694, 25);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // colDoctorID
            // 
            colDoctorID.HeaderText = "ID";
            colDoctorID.MinimumWidth = 6;
            colDoctorID.Name = "colDoctorID";
            colDoctorID.ReadOnly = true;
            colDoctorID.Width = 125;
            // 
            // colDoctorName
            // 
            colDoctorName.HeaderText = "Name";
            colDoctorName.MinimumWidth = 6;
            colDoctorName.Name = "colDoctorName";
            colDoctorName.ReadOnly = true;
            colDoctorName.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 125;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            colDepartment.Width = 125;
            // 
            // colSpecialization
            // 
            colSpecialization.HeaderText = "Specialization";
            colSpecialization.MinimumWidth = 6;
            colSpecialization.Name = "colSpecialization";
            colSpecialization.ReadOnly = true;
            colSpecialization.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(-1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 73);
            panel1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(26, 16);
            label8.Name = "label8";
            label8.Size = new Size(466, 38);
            label8.TabIndex = 11;
            label8.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(532, 16);
            label9.Name = "label9";
            label9.Size = new Size(98, 38);
            label9.TabIndex = 12;
            label9.Text = "Admin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Highlight;
            label10.Location = new Point(38, 79);
            label10.Name = "label10";
            label10.Size = new Size(187, 31);
            label10.TabIndex = 13;
            label10.Text = "Manage Doctors";
            // 
            // ManageDoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 617);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(txtSearch);
            Controls.Add(dgvDoctors);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "ManageDoctorsForm";
            Text = "ManageDoctorsForm";
            label5.ResumeLayout(false);
            label5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private DataGridView dgvDoctors;
        private TextBox txtDoctorEmail;
        private TextBox txtDoctorName;
        private TextBox txtDoctorID;
        private TextBox txtSearch;
        private TextBox txtSpecialization;
        private ComboBox cmbDepartment;
        private Label label7;
        private Button btnBack;
        private DataGridViewTextBoxColumn colDoctorID;
        private DataGridViewTextBoxColumn colDoctorName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colSpecialization;
        private Panel panel1;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}