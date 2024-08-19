namespace EducationCentre
{
    partial class StudentForm
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
            listViewStudentSubject = new ListView();
            columnStudentSubjectId = new ColumnHeader();
            columnStudentSubjectName = new ColumnHeader();
            columnStudentSubjectStatus = new ColumnHeader();
            btnStudentAssign = new Button();
            btnStudentSubjectDelete = new Button();
            lblShowSubjects = new Label();
            SuspendLayout();
            // 
            // listViewStudentSubject
            // 
            listViewStudentSubject.Columns.AddRange(new ColumnHeader[] { columnStudentSubjectId, columnStudentSubjectName, columnStudentSubjectStatus });
            listViewStudentSubject.Location = new Point(30, 40);
            listViewStudentSubject.Name = "listViewStudentSubject";
            listViewStudentSubject.Size = new Size(717, 237);
            listViewStudentSubject.TabIndex = 0;
            listViewStudentSubject.UseCompatibleStateImageBehavior = false;
            listViewStudentSubject.View = View.Details;
            listViewStudentSubject.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnStudentSubjectId
            // 
            columnStudentSubjectId.Text = "Id";
            // 
            // columnStudentSubjectName
            // 
            columnStudentSubjectName.Text = "Subject";
            columnStudentSubjectName.Width = 100;
            // 
            // columnStudentSubjectStatus
            // 
            columnStudentSubjectStatus.Text = "Status";
            columnStudentSubjectStatus.Width = 100;
            // 
            // btnStudentAssign
            // 
            btnStudentAssign.Location = new Point(511, 315);
            btnStudentAssign.Name = "btnStudentAssign";
            btnStudentAssign.Size = new Size(163, 29);
            btnStudentAssign.TabIndex = 2;
            btnStudentAssign.Text = "Register a subject";
            btnStudentAssign.UseVisualStyleBackColor = true;
            btnStudentAssign.Click += btnStudentAssign_Click;
            // 
            // btnStudentSubjectDelete
            // 
            btnStudentSubjectDelete.Location = new Point(511, 371);
            btnStudentSubjectDelete.Name = "btnStudentSubjectDelete";
            btnStudentSubjectDelete.Size = new Size(163, 29);
            btnStudentSubjectDelete.TabIndex = 3;
            btnStudentSubjectDelete.Text = "Unregister";
            btnStudentSubjectDelete.UseVisualStyleBackColor = true;
            btnStudentSubjectDelete.Click += button1_Click;
            // 
            // lblShowSubjects
            // 
            lblShowSubjects.AutoSize = true;
            lblShowSubjects.Location = new Point(46, 315);
            lblShowSubjects.Name = "lblShowSubjects";
            lblShowSubjects.Size = new Size(0, 20);
            lblShowSubjects.TabIndex = 4;
            lblShowSubjects.Click += label1_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblShowSubjects);
            Controls.Add(btnStudentSubjectDelete);
            Controls.Add(btnStudentAssign);
            Controls.Add(listViewStudentSubject);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewStudentSubject;
        private ColumnHeader columnStudentSubjectId;
        private ColumnHeader columnStudentSubjectName;
        private ColumnHeader columnStudentSubjectStatus;
        private Button btnStudentAssign;
        private Button btnStudentSubjectDelete;
        private Label lblShowSubjects;
    }
}