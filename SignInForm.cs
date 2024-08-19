using EducationCentre.context;
using EducationCentre.models;
using EducationCentre.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationCentre
{
    public partial class SignInForm : Form
    {
        private AuthenticationService authenticationService = ServiceFactory.GetService<AuthenticationService>(ServiceType.Authentication);
        
        public SignInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                AuthenticationContext.Authentication = authenticationService.Login(txBEmail.Text, txBPassword.Text);
                MessageBox.Show("Login successful");
                switch (AuthenticationContext.Authentication.Profile.Role)
                {
                    case Role.Administration:
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;
                    case Role.TeachingStaff:
                        TeacherForm teacherForm = new TeacherForm();
                        teacherForm.Show();
                        break;
                    case Role.Student:
                        StudentForm studentForm = new StudentForm();
                        studentForm.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
