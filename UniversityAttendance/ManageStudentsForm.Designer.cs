namespace University_Attendance_System
{
    partial class ManageStudentsForm
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
            grpStudentInfo = new GroupBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cmbSubject = new ComboBox();
            label5 = new Label();
            cmbYear = new ComboBox();
            cmbDepartment = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtStudentName = new TextBox();
            txtStudentID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            dgvStudents = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colSubject = new DataGridViewTextBoxColumn();
            lblStudentsList = new Label();
            txtSearch = new TextBox();
            btnBack = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            grpStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(28, 76);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Students";
            // 
            // grpStudentInfo
            // 
            grpStudentInfo.Controls.Add(txtEmail);
            grpStudentInfo.Controls.Add(lblEmail);
            grpStudentInfo.Controls.Add(cmbSubject);
            grpStudentInfo.Controls.Add(label5);
            grpStudentInfo.Controls.Add(cmbYear);
            grpStudentInfo.Controls.Add(cmbDepartment);
            grpStudentInfo.Controls.Add(label4);
            grpStudentInfo.Controls.Add(label3);
            grpStudentInfo.Controls.Add(txtStudentName);
            grpStudentInfo.Controls.Add(txtStudentID);
            grpStudentInfo.Controls.Add(label2);
            grpStudentInfo.Controls.Add(label1);
            grpStudentInfo.Location = new Point(28, 119);
            grpStudentInfo.Name = "grpStudentInfo";
            grpStudentInfo.Size = new Size(815, 157);
            grpStudentInfo.TabIndex = 1;
            grpStudentInfo.TabStop = false;
            grpStudentInfo.Text = "Student Information";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your Email";
            txtEmail.Size = new Size(165, 27);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(28, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email :";
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Database", "Logic Design", "C++" });
            cmbSubject.Location = new Point(509, 114);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(183, 28);
            cmbSubject.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 117);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "Subject";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "First Year", "Second Year", "Third Year", "Fourth Year" });
            cmbYear.Location = new Point(509, 70);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(183, 28);
            cmbYear.TabIndex = 7;
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = SystemColors.Window;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.ForeColor = SystemColors.WindowText;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Computer Science", "Artifical Intelligence", "Information Systems" });
            cmbDepartment.Location = new Point(509, 26);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(183, 28);
            cmbDepartment.TabIndex = 6;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 73);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 5;
            label4.Text = "Academic Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 29);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 4;
            label3.Text = "Department";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(117, 74);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.PlaceholderText = "Enter your Name";
            txtStudentName.Size = new Size(165, 27);
            txtStudentName.TabIndex = 3;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(117, 22);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PlaceholderText = "Enter your ID";
            txtStudentID.Size = new Size(165, 27);
            txtStudentID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Student Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(93, 282);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLightLight;
            btnUpdate.Location = new Point(240, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.Location = new Point(482, 282);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(626, 282);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(749, 330);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = SystemColors.ButtonHighlight;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colEmail, colDepartment, colYear, colSubject });
            dgvStudents.GridColor = SystemColors.GrayText;
            dgvStudents.Location = new Point(11, 396);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(884, 181);
            dgvStudents.TabIndex = 13;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.HeaderText = "Academic Year";
            colYear.MinimumWidth = 6;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colSubject
            // 
            colSubject.HeaderText = "Subject";
            colSubject.MinimumWidth = 6;
            colSubject.Name = "colSubject";
            colSubject.ReadOnly = true;
            // 
            // lblStudentsList
            // 
            lblStudentsList.AutoSize = true;
            lblStudentsList.Location = new Point(17, 362);
            lblStudentsList.Name = "lblStudentsList";
            lblStudentsList.Size = new Size(92, 20);
            lblStudentsList.TabIndex = 14;
            lblStudentsList.Text = "Students List";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(107, 332);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID";
            txtSearch.Size = new Size(610, 27);
            txtSearch.TabIndex = 15;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(768, 16);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 73);
            panel1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(17, 9);
            label6.Name = "label6";
            label6.Size = new Size(466, 38);
            label6.TabIndex = 0;
            label6.Text = "UNIVERSITY | ATTENDANCE SYSTEM";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(591, 9);
            label7.Name = "label7";
            label7.Size = new Size(98, 38);
            label7.TabIndex = 1;
            label7.Text = "Admin";
            // 
            // ManageStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 589);
            Controls.Add(panel1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearch);
            Controls.Add(btnClear);
            Controls.Add(lblStudentsList);
            Controls.Add(dgvStudents);
            Controls.Add(grpStudentInfo);
            Controls.Add(lblTitle);
            Name = "ManageStudentsForm";
            Text = "Manage Students";
            Load += ManageStudentsForm_Load;
            grpStudentInfo.ResumeLayout(false);
            grpStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpStudentInfo;
        private TextBox txtStudentName;
        private TextBox txtStudentID;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cmbYear;
        private ComboBox cmbDepartment;
        private Label label4;
        private Label label3;
        private DataGridView dgvStudents;
        private Button btnSearch;
        private Button btnClear;
        private Label lblStudentsList;
        private TextBox txtSearch;
        private ComboBox cmbSubject;
        private Label label5;
        private Button btnBack;
        private TextBox txtEmail;
        private Label lblEmail;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colSubject;
        private Panel panel1;
        private Label label6;
        private Label label7;
    }
}