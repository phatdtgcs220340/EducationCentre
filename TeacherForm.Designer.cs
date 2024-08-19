namespace EducationCentre
{
    partial class TeacherForm
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
            listViewTeacherSubject = new ListView();
            columnSubjectId = new ColumnHeader();
            columnSubject = new ColumnHeader();
            columnStatus = new ColumnHeader();
            lblShowSubjects = new Label();
            btnRegister = new Button();
            btnUnRegister = new Button();
            SuspendLayout();
            // 
            // listViewTeacherSubject
            // 
            listViewTeacherSubject.Columns.AddRange(new ColumnHeader[] { columnSubjectId, columnSubject, columnStatus });
            listViewTeacherSubject.Location = new Point(28, 22);
            listViewTeacherSubject.Name = "listViewTeacherSubject";
            listViewTeacherSubject.Size = new Size(734, 271);
            listViewTeacherSubject.TabIndex = 0;
            listViewTeacherSubject.UseCompatibleStateImageBehavior = false;
            listViewTeacherSubject.View = View.Details;
            // 
            // columnSubjectId
            // 
            columnSubjectId.Text = "Id";
            columnSubjectId.Width = 40;
            // 
            // columnSubject
            // 
            columnSubject.Text = "Subject";
            columnSubject.Width = 120;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 120;
            // 
            // lblShowSubjects
            // 
            lblShowSubjects.AutoSize = true;
            lblShowSubjects.Location = new Point(30, 337);
            lblShowSubjects.Name = "lblShowSubjects";
            lblShowSubjects.Size = new Size(0, 20);
            lblShowSubjects.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(525, 336);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(149, 29);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnUnRegister
            // 
            btnUnRegister.Location = new Point(525, 386);
            btnUnRegister.Name = "btnUnRegister";
            btnUnRegister.Size = new Size(149, 29);
            btnUnRegister.TabIndex = 3;
            btnUnRegister.Text = "Unregister";
            btnUnRegister.UseVisualStyleBackColor = true;
            btnUnRegister.Click += btnUnRegister_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUnRegister);
            Controls.Add(btnRegister);
            Controls.Add(lblShowSubjects);
            Controls.Add(listViewTeacherSubject);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewTeacherSubject;
        private ColumnHeader columnSubjectId;
        private ColumnHeader columnSubject;
        private ColumnHeader columnStatus;
        private Label lblShowSubjects;
        private Button btnRegister;
        private Button btnUnRegister;
    }
}