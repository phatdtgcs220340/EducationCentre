namespace EducationCentre
{
    partial class AdminForm
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
            tabControl1 = new TabControl();
            tabPageSubject = new TabPage();
            btnDeleteSubject = new Button();
            listViewSubject = new ListView();
            Id = new ColumnHeader();
            Subject = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            btnSave = new Button();
            txBSubject = new TextBox();
            lblSubjectName = new Label();
            lblSubject = new Label();
            tabPageStudent = new TabPage();
            listViewStudent = new ListView();
            columnStudentId = new ColumnHeader();
            columnStudentName = new ColumnHeader();
            columnCurrentSubject1 = new ColumnHeader();
            columnCurrentSubject2 = new ColumnHeader();
            columnPreviousSubject1 = new ColumnHeader();
            columnPreviousSubject2 = new ColumnHeader();
            tabPageTeacher = new TabPage();
            btnUpdateTeacher = new Button();
            label6 = new Label();
            label5 = new Label();
            txBSalary = new TextBox();
            txBMonth = new TextBox();
            listViewTeacher = new ListView();
            columnTeacherId = new ColumnHeader();
            columnTeacherName = new ColumnHeader();
            columnTeacherSalary = new ColumnHeader();
            columnTeacherSalaryMonth = new ColumnHeader();
            columnTeacherSubject1 = new ColumnHeader();
            columnTeacherSubject2 = new ColumnHeader();
            tabPageAdmin = new TabPage();
            button1 = new Button();
            cbBAdminStatus = new ComboBox();
            txBAdminWrkHrs = new TextBox();
            txBAdminMonth = new TextBox();
            txBAdminSalary = new TextBox();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            listViewAdmin = new ListView();
            columnAdminId = new ColumnHeader();
            columnAdminName = new ColumnHeader();
            columnAdminSalary = new ColumnHeader();
            columnAdminMonth = new ColumnHeader();
            columnAdminStatus = new ColumnHeader();
            columnWorkDura = new ColumnHeader();
            tabPageProfile = new TabPage();
            btnProfileUpdate = new Button();
            label4 = new Label();
            cbBProfileRole = new ComboBox();
            btnProfileSave = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblName = new Label();
            txBProfilePassword = new TextBox();
            txBProfileEmail = new TextBox();
            txBProfileTelephone = new TextBox();
            txBProfileName = new TextBox();
            listViewProfile = new ListView();
            columnProfileId = new ColumnHeader();
            columnProfileName = new ColumnHeader();
            columnProfileEmail = new ColumnHeader();
            columnProfileTelephone = new ColumnHeader();
            columnProfileRole = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPageSubject.SuspendLayout();
            tabPageStudent.SuspendLayout();
            tabPageTeacher.SuspendLayout();
            tabPageAdmin.SuspendLayout();
            tabPageProfile.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleName = "Subject";
            tabControl1.Controls.Add(tabPageSubject);
            tabControl1.Controls.Add(tabPageStudent);
            tabControl1.Controls.Add(tabPageTeacher);
            tabControl1.Controls.Add(tabPageAdmin);
            tabControl1.Controls.Add(tabPageProfile);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPageSubject
            // 
            tabPageSubject.Controls.Add(btnDeleteSubject);
            tabPageSubject.Controls.Add(listViewSubject);
            tabPageSubject.Controls.Add(btnSave);
            tabPageSubject.Controls.Add(txBSubject);
            tabPageSubject.Controls.Add(lblSubjectName);
            tabPageSubject.Controls.Add(lblSubject);
            tabPageSubject.Location = new Point(4, 29);
            tabPageSubject.Name = "tabPageSubject";
            tabPageSubject.Padding = new Padding(3);
            tabPageSubject.Size = new Size(768, 393);
            tabPageSubject.TabIndex = 0;
            tabPageSubject.Text = "Subject";
            tabPageSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(456, 282);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(94, 29);
            btnDeleteSubject.TabIndex = 6;
            btnDeleteSubject.Text = "Delete";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click_1;
            // 
            // listViewSubject
            // 
            listViewSubject.Columns.AddRange(new ColumnHeader[] { Id, Subject, columnHeader1 });
            listViewSubject.Location = new Point(19, 18);
            listViewSubject.Name = "listViewSubject";
            listViewSubject.Size = new Size(725, 176);
            listViewSubject.TabIndex = 5;
            listViewSubject.UseCompatibleStateImageBehavior = false;
            listViewSubject.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Subject
            // 
            Subject.Text = "Subject";
            Subject.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date created";
            columnHeader1.Width = 200;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(126, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txBSubject
            // 
            txBSubject.Location = new Point(126, 279);
            txBSubject.Name = "txBSubject";
            txBSubject.Size = new Size(125, 27);
            txBSubject.TabIndex = 3;
            txBSubject.TextChanged += txBSubject_TextChanged;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(52, 282);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(58, 20);
            lblSubjectName.TabIndex = 2;
            lblSubjectName.Text = "Subject";
            lblSubjectName.Click += lblSubjectName_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(286, 241);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(150, 20);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject Management";
            lblSubject.Click += label1_Click;
            // 
            // tabPageStudent
            // 
            tabPageStudent.Controls.Add(listViewStudent);
            tabPageStudent.Location = new Point(4, 29);
            tabPageStudent.Name = "tabPageStudent";
            tabPageStudent.Padding = new Padding(3);
            tabPageStudent.Size = new Size(768, 393);
            tabPageStudent.TabIndex = 1;
            tabPageStudent.Text = "Student";
            tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // listViewStudent
            // 
            listViewStudent.Columns.AddRange(new ColumnHeader[] { columnStudentId, columnStudentName, columnCurrentSubject1, columnCurrentSubject2, columnPreviousSubject1, columnPreviousSubject2 });
            listViewStudent.Location = new Point(19, 20);
            listViewStudent.Name = "listViewStudent";
            listViewStudent.Size = new Size(725, 325);
            listViewStudent.TabIndex = 0;
            listViewStudent.UseCompatibleStateImageBehavior = false;
            listViewStudent.View = View.Details;
            // 
            // columnStudentId
            // 
            columnStudentId.Text = "Id";
            columnStudentId.Width = 40;
            // 
            // columnStudentName
            // 
            columnStudentName.Text = "Name";
            columnStudentName.Width = 140;
            // 
            // columnCurrentSubject1
            // 
            columnCurrentSubject1.Text = "CurrentSubject1";
            columnCurrentSubject1.Width = 120;
            // 
            // columnCurrentSubject2
            // 
            columnCurrentSubject2.Text = "CurrentSubject2";
            columnCurrentSubject2.Width = 120;
            // 
            // columnPreviousSubject1
            // 
            columnPreviousSubject1.Text = "PreviousSubject1";
            columnPreviousSubject1.Width = 140;
            // 
            // columnPreviousSubject2
            // 
            columnPreviousSubject2.Text = "PreviousSubject2";
            columnPreviousSubject2.Width = 140;
            // 
            // tabPageTeacher
            // 
            tabPageTeacher.Controls.Add(btnUpdateTeacher);
            tabPageTeacher.Controls.Add(label6);
            tabPageTeacher.Controls.Add(label5);
            tabPageTeacher.Controls.Add(txBSalary);
            tabPageTeacher.Controls.Add(txBMonth);
            tabPageTeacher.Controls.Add(listViewTeacher);
            tabPageTeacher.Location = new Point(4, 29);
            tabPageTeacher.Name = "tabPageTeacher";
            tabPageTeacher.Size = new Size(768, 393);
            tabPageTeacher.TabIndex = 2;
            tabPageTeacher.Text = "Teacher";
            tabPageTeacher.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTeacher
            // 
            btnUpdateTeacher.Location = new Point(453, 272);
            btnUpdateTeacher.Name = "btnUpdateTeacher";
            btnUpdateTeacher.Size = new Size(131, 43);
            btnUpdateTeacher.TabIndex = 5;
            btnUpdateTeacher.Text = "Update";
            btnUpdateTeacher.UseVisualStyleBackColor = true;
            btnUpdateTeacher.Click += btnUpdateTeacher_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 295);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 4;
            label6.Text = "Month";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 226);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 3;
            label5.Text = "Salary";
            // 
            // txBSalary
            // 
            txBSalary.Location = new Point(31, 318);
            txBSalary.Name = "txBSalary";
            txBSalary.Size = new Size(125, 27);
            txBSalary.TabIndex = 2;
            // 
            // txBMonth
            // 
            txBMonth.Location = new Point(31, 249);
            txBMonth.Name = "txBMonth";
            txBMonth.Size = new Size(125, 27);
            txBMonth.TabIndex = 1;
            // 
            // listViewTeacher
            // 
            listViewTeacher.Columns.AddRange(new ColumnHeader[] { columnTeacherId, columnTeacherName, columnTeacherSalary, columnTeacherSalaryMonth, columnTeacherSubject1, columnTeacherSubject2 });
            listViewTeacher.FullRowSelect = true;
            listViewTeacher.Location = new Point(15, 14);
            listViewTeacher.MultiSelect = false;
            listViewTeacher.Name = "listViewTeacher";
            listViewTeacher.Size = new Size(734, 178);
            listViewTeacher.TabIndex = 0;
            listViewTeacher.UseCompatibleStateImageBehavior = false;
            listViewTeacher.View = View.Details;
            listViewTeacher.SelectedIndexChanged += listViewTeacher_SelectedIndexChanged;
            // 
            // columnTeacherId
            // 
            columnTeacherId.Text = "Id";
            columnTeacherId.Width = 40;
            // 
            // columnTeacherName
            // 
            columnTeacherName.Text = "Name";
            columnTeacherName.Width = 120;
            // 
            // columnTeacherSalary
            // 
            columnTeacherSalary.Text = "Salary";
            columnTeacherSalary.Width = 120;
            // 
            // columnTeacherSalaryMonth
            // 
            columnTeacherSalaryMonth.Text = "Month";
            // 
            // columnTeacherSubject1
            // 
            columnTeacherSubject1.Text = "Subject 1";
            columnTeacherSubject1.Width = 140;
            // 
            // columnTeacherSubject2
            // 
            columnTeacherSubject2.Text = "Subject 2";
            columnTeacherSubject2.Width = 140;
            // 
            // tabPageAdmin
            // 
            tabPageAdmin.Controls.Add(button1);
            tabPageAdmin.Controls.Add(cbBAdminStatus);
            tabPageAdmin.Controls.Add(txBAdminWrkHrs);
            tabPageAdmin.Controls.Add(txBAdminMonth);
            tabPageAdmin.Controls.Add(txBAdminSalary);
            tabPageAdmin.Controls.Add(label8);
            tabPageAdmin.Controls.Add(label10);
            tabPageAdmin.Controls.Add(label9);
            tabPageAdmin.Controls.Add(label7);
            tabPageAdmin.Controls.Add(listViewAdmin);
            tabPageAdmin.Location = new Point(4, 29);
            tabPageAdmin.Name = "tabPageAdmin";
            tabPageAdmin.Size = new Size(768, 393);
            tabPageAdmin.TabIndex = 3;
            tabPageAdmin.Text = "Admin";
            tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(528, 291);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // cbBAdminStatus
            // 
            cbBAdminStatus.FormattingEnabled = true;
            cbBAdminStatus.Items.AddRange(new object[] { "full-time", "part-time" });
            cbBAdminStatus.Location = new Point(241, 275);
            cbBAdminStatus.Name = "cbBAdminStatus";
            cbBAdminStatus.Size = new Size(129, 28);
            cbBAdminStatus.TabIndex = 6;
            // 
            // txBAdminWrkHrs
            // 
            txBAdminWrkHrs.Location = new Point(245, 343);
            txBAdminWrkHrs.Name = "txBAdminWrkHrs";
            txBAdminWrkHrs.Size = new Size(125, 27);
            txBAdminWrkHrs.TabIndex = 5;
            // 
            // txBAdminMonth
            // 
            txBAdminMonth.Location = new Point(34, 343);
            txBAdminMonth.Name = "txBAdminMonth";
            txBAdminMonth.Size = new Size(125, 27);
            txBAdminMonth.TabIndex = 3;
            // 
            // txBAdminSalary
            // 
            txBAdminSalary.Location = new Point(36, 276);
            txBAdminSalary.Name = "txBAdminSalary";
            txBAdminSalary.Size = new Size(125, 27);
            txBAdminSalary.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 313);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 1;
            label8.Text = "Month";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 313);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 1;
            label10.Text = "Working hours";
            label10.Click += label9_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(241, 243);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 1;
            label9.Text = "Status";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 243);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 1;
            label7.Text = "Salary";
            // 
            // listViewAdmin
            // 
            listViewAdmin.Columns.AddRange(new ColumnHeader[] { columnAdminId, columnAdminName, columnAdminSalary, columnAdminMonth, columnAdminStatus, columnWorkDura });
            listViewAdmin.FullRowSelect = true;
            listViewAdmin.Location = new Point(24, 20);
            listViewAdmin.MultiSelect = false;
            listViewAdmin.Name = "listViewAdmin";
            listViewAdmin.Size = new Size(714, 193);
            listViewAdmin.TabIndex = 0;
            listViewAdmin.UseCompatibleStateImageBehavior = false;
            listViewAdmin.View = View.Details;
            listViewAdmin.SelectedIndexChanged += listViewAdmin_SelectedIndexChanged;
            // 
            // columnAdminId
            // 
            columnAdminId.Text = "Id";
            columnAdminId.Width = 40;
            // 
            // columnAdminName
            // 
            columnAdminName.Text = "Name";
            columnAdminName.Width = 150;
            // 
            // columnAdminSalary
            // 
            columnAdminSalary.Text = "Salary";
            columnAdminSalary.Width = 150;
            // 
            // columnAdminMonth
            // 
            columnAdminMonth.Text = "Month";
            // 
            // columnAdminStatus
            // 
            columnAdminStatus.Text = "Status";
            columnAdminStatus.Width = 100;
            // 
            // columnWorkDura
            // 
            columnWorkDura.Text = "Work duration";
            // 
            // tabPageProfile
            // 
            tabPageProfile.Controls.Add(btnProfileUpdate);
            tabPageProfile.Controls.Add(label4);
            tabPageProfile.Controls.Add(cbBProfileRole);
            tabPageProfile.Controls.Add(btnProfileSave);
            tabPageProfile.Controls.Add(label3);
            tabPageProfile.Controls.Add(label2);
            tabPageProfile.Controls.Add(label1);
            tabPageProfile.Controls.Add(lblName);
            tabPageProfile.Controls.Add(txBProfilePassword);
            tabPageProfile.Controls.Add(txBProfileEmail);
            tabPageProfile.Controls.Add(txBProfileTelephone);
            tabPageProfile.Controls.Add(txBProfileName);
            tabPageProfile.Controls.Add(listViewProfile);
            tabPageProfile.Location = new Point(4, 29);
            tabPageProfile.Name = "tabPageProfile";
            tabPageProfile.Padding = new Padding(3);
            tabPageProfile.Size = new Size(768, 393);
            tabPageProfile.TabIndex = 4;
            tabPageProfile.Text = "Profile";
            tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // btnProfileUpdate
            // 
            btnProfileUpdate.Location = new Point(583, 285);
            btnProfileUpdate.Name = "btnProfileUpdate";
            btnProfileUpdate.Size = new Size(94, 29);
            btnProfileUpdate.TabIndex = 12;
            btnProfileUpdate.Text = "Update";
            btnProfileUpdate.UseVisualStyleBackColor = true;
            btnProfileUpdate.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 259);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 11;
            label4.Text = "Role";
            // 
            // cbBProfileRole
            // 
            cbBProfileRole.FormattingEnabled = true;
            cbBProfileRole.Items.AddRange(new object[] { "Administration", "TeachingStaff", "Student" });
            cbBProfileRole.Location = new Point(383, 282);
            cbBProfileRole.Name = "cbBProfileRole";
            cbBProfileRole.Size = new Size(151, 28);
            cbBProfileRole.TabIndex = 10;
            // 
            // btnProfileSave
            // 
            btnProfileSave.Location = new Point(583, 340);
            btnProfileSave.Name = "btnProfileSave";
            btnProfileSave.Size = new Size(94, 29);
            btnProfileSave.TabIndex = 9;
            btnProfileSave.Text = "Save";
            btnProfileSave.UseVisualStyleBackColor = true;
            btnProfileSave.Click += btnProfileSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 319);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 260);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 319);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Telephone";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 260);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Name";
            // 
            // txBProfilePassword
            // 
            txBProfilePassword.Location = new Point(240, 342);
            txBProfilePassword.Name = "txBProfilePassword";
            txBProfilePassword.PasswordChar = '*';
            txBProfilePassword.Size = new Size(125, 27);
            txBProfilePassword.TabIndex = 4;
            // 
            // txBProfileEmail
            // 
            txBProfileEmail.Location = new Point(240, 283);
            txBProfileEmail.Name = "txBProfileEmail";
            txBProfileEmail.Size = new Size(125, 27);
            txBProfileEmail.TabIndex = 3;
            // 
            // txBProfileTelephone
            // 
            txBProfileTelephone.Location = new Point(40, 342);
            txBProfileTelephone.Name = "txBProfileTelephone";
            txBProfileTelephone.Size = new Size(125, 27);
            txBProfileTelephone.TabIndex = 2;
            // 
            // txBProfileName
            // 
            txBProfileName.Location = new Point(40, 283);
            txBProfileName.Name = "txBProfileName";
            txBProfileName.Size = new Size(125, 27);
            txBProfileName.TabIndex = 1;
            // 
            // listViewProfile
            // 
            listViewProfile.Columns.AddRange(new ColumnHeader[] { columnProfileId, columnProfileName, columnProfileEmail, columnProfileTelephone, columnProfileRole });
            listViewProfile.FullRowSelect = true;
            listViewProfile.Location = new Point(20, 15);
            listViewProfile.MultiSelect = false;
            listViewProfile.Name = "listViewProfile";
            listViewProfile.Size = new Size(726, 217);
            listViewProfile.TabIndex = 0;
            listViewProfile.UseCompatibleStateImageBehavior = false;
            listViewProfile.View = View.Details;
            listViewProfile.SelectedIndexChanged += listViewProfile_SelectedIndexChanged;
            // 
            // columnProfileId
            // 
            columnProfileId.Text = "Id";
            columnProfileId.Width = 40;
            // 
            // columnProfileName
            // 
            columnProfileName.Text = "Name";
            columnProfileName.Width = 150;
            // 
            // columnProfileEmail
            // 
            columnProfileEmail.Text = "Email";
            columnProfileEmail.Width = 150;
            // 
            // columnProfileTelephone
            // 
            columnProfileTelephone.Text = "Telephone";
            columnProfileTelephone.Width = 150;
            // 
            // columnProfileRole
            // 
            columnProfileRole.Text = "Role";
            columnProfileRole.Width = 120;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            tabControl1.ResumeLayout(false);
            tabPageSubject.ResumeLayout(false);
            tabPageSubject.PerformLayout();
            tabPageStudent.ResumeLayout(false);
            tabPageTeacher.ResumeLayout(false);
            tabPageTeacher.PerformLayout();
            tabPageAdmin.ResumeLayout(false);
            tabPageAdmin.PerformLayout();
            tabPageProfile.ResumeLayout(false);
            tabPageProfile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageSubject;
        private TabPage tabPageStudent;
        private Button btnSave;
        private TextBox txBSubject;
        private Label lblSubjectName;
        private Label lblSubject;
        private ListView listViewSubject;
        private Button btnDeleteSubject;
        private ColumnHeader Id;
        private ColumnHeader Subject;
        private ColumnHeader columnHeader1;
        private TabPage tabPageTeacher;
        private TabPage tabPageAdmin;
        private ListView listViewStudent;
        private ColumnHeader columnStudentId;
        private ColumnHeader columnStudentName;
        private ColumnHeader columnCurrentSubject1;
        private ColumnHeader columnCurrentSubject2;
        private ColumnHeader columnPreviousSubject1;
        private ColumnHeader columnPreviousSubject2;
        private TabPage tabPageProfile;
        private ListView listViewProfile;
        private ColumnHeader columnProfileId;
        private ColumnHeader columnProfileName;
        private ColumnHeader columnProfileEmail;
        private ColumnHeader columnProfileTelephone;
        private ColumnHeader columnProfileRole;
        private TextBox txBProfileName;
        private TextBox txBProfileTelephone;
        private TextBox txBProfilePassword;
        private TextBox txBProfileEmail;
        private Label lblName;
        private Button btnProfileSave;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbBProfileRole;
        private ListView listViewTeacher;
        private ColumnHeader columnTeacherId;
        private ColumnHeader columnTeacherName;
        private ColumnHeader columnTeacherSalary;
        private ColumnHeader columnTeacherSalaryMonth;
        private ColumnHeader columnTeacherSubject1;
        private ColumnHeader columnTeacherSubject2;
        private Label label4;
        private Button btnProfileUpdate;
        private Label label6;
        private Label label5;
        private TextBox txBSalary;
        private TextBox txBMonth;
        private Button btnUpdateTeacher;
        private Label label8;
        private Label label9;
        private Label label7;
        private ListView listViewAdmin;
        private TextBox txBAdminWrkHrs;
        private TextBox txBAdminMonth;
        private TextBox txBAdminSalary;
        private Label label10;
        private ComboBox cbBAdminStatus;
        private Button button1;
        private ColumnHeader columnAdminId;
        private ColumnHeader columnAdminName;
        private ColumnHeader columnAdminSalary;
        private ColumnHeader columnAdminMonth;
        private ColumnHeader columnAdminStatus;
        private ColumnHeader columnWorkDura;
    }
}