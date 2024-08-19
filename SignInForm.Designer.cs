namespace EducationCentre
{
    partial class SignInForm
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
            lblSignIn = new Label();
            lblEmail = new Label();
            txBEmail = new TextBox();
            lblPassword = new Label();
            txBPassword = new TextBox();
            btnSignIn = new Button();
            lblMessage = new Label();
            linkSignUp = new LinkLabel();
            SuspendLayout();
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Location = new Point(130, 18);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(58, 20);
            lblSignIn.TabIndex = 0;
            lblSignIn.Text = "Sign In ";
            lblSignIn.Click += label1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(48, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            lblEmail.Click += label1_Click_1;
            // 
            // txBEmail
            // 
            txBEmail.Location = new Point(48, 89);
            txBEmail.Name = "txBEmail";
            txBEmail.Size = new Size(207, 27);
            txBEmail.TabIndex = 2;
            txBEmail.TextChanged += textBox1_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(48, 134);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txBPassword
            // 
            txBPassword.Location = new Point(48, 157);
            txBPassword.Name = "txBPassword";
            txBPassword.Size = new Size(207, 27);
            txBPassword.TabIndex = 4;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(121, 219);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 29);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Submit";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(44, 266);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 6;
            lblMessage.Click += label1_Click_2;
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.Location = new Point(60, 268);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(59, 20);
            linkSignUp.TabIndex = 7;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 319);
            Controls.Add(linkSignUp);
            Controls.Add(lblMessage);
            Controls.Add(btnSignIn);
            Controls.Add(txBPassword);
            Controls.Add(lblPassword);
            Controls.Add(txBEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblSignIn);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignIn;
        private Label lblEmail;
        private TextBox txBEmail;
        private Label lblPassword;
        private TextBox txBPassword;
        private Button btnSignIn;
        private Label lblMessage;
        private LinkLabel linkSignUp;
    }
}