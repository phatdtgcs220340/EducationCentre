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
    public partial class AdminForm : Form
    {
        private SubjectService subjectService = ServiceFactory.GetService<SubjectService>(ServiceType.Subject);
        private AdministrationService administrationService = ServiceFactory.GetService<AdministrationService>(ServiceType.Administration);
        private AuthenticationService authenticationService = ServiceFactory.GetService<AuthenticationService>(ServiceType.Authentication);
        public AdminForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadProfileLists();
            LoadStudentList();
            LoadTeacherList();
            LoadAdminList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubjectName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newSubject = subjectService.Save(new models.Subject()
            {
                Name = txBSubject.Text,
                DateCreated = DateTime.Now
            });
            ListViewItem item = new ListViewItem(newSubject.Id.ToString());
            item.SubItems.Add(newSubject.Name);
            item.SubItems.Add(newSubject.DateCreated.ToString());
            listViewSubject.Items.Add(item);
        }

        private void txBSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete!");
                return;
            }
            else
            {
                var selectedSubject = listViewSubject.SelectedItems[0];
                subjectService.Delete(int.Parse(selectedSubject.SubItems[0].Text));
                listViewSubject.Items.Remove(selectedSubject);
                MessageBox.Show("Subject deleted successfully!");
            }
        }

        private void btnDeleteSubject_Click_1(object sender, EventArgs e)
        {
            if (listViewSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete!");
                return;
            }
            else
            {
                var selectedSubject = listViewSubject.SelectedItems[0];
                subjectService.Delete(int.Parse(selectedSubject.SubItems[0].Text));
                listViewSubject.Items.Remove(selectedSubject);
                MessageBox.Show("Subject deleted successfully!");
            }
        }
        private void LoadStudentList()
        {
            listViewStudent.Items.Clear();
            administrationService.students().ForEach(s =>
            {
                ListViewItem item = new ListViewItem(s.Id.ToString());
                item.SubItems.Add(s.Profile.Name);
                s.Subjects.ForEach(subject =>
                {
                    item.SubItems.Add(subject.Name);
                });
                listViewStudent.Items.Add(item);
            });
        }
        private void LoadSubjects()
        {
            listViewSubject.Items.Clear();
            subjectService.FindAll().ForEach(subject =>
            {
                ListViewItem item = new ListViewItem(subject.Id.ToString());
                item.SubItems.Add(subject.Name);
                item.SubItems.Add(subject.DateCreated.ToString());
                listViewSubject.Items.Add(item);
            });
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
        private void btnProfileSave_Click(object sender, EventArgs e)
        {
            var form = new Validator.RegisterForm()
            {
                Email = txBProfileEmail.Text,
                Name = txBProfileName.Text,
                Password = txBProfilePassword.Text,
                Telephone = txBProfileTelephone.Text
            };

            try
            {
                authenticationService.Register(new Profile
                {
                    Email = form.Email,
                    Name = form.Name,
                    Password = form.Password,
                    Role = (Role)Enum.Parse(typeof(Role), cbBProfileRole.Text),
                    Telephone = form.Telephone
                });
                LoadProfileLists();
                MessageBox.Show("Profile saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadProfileLists()
        {
            listViewProfile.Items.Clear();
            administrationService.profiles().ForEach(profile =>
            {
                ListViewItem item = new ListViewItem(profile.Id.ToString());
                item.SubItems.Add(profile.Name);
                item.SubItems.Add(profile.Email);
                item.SubItems.Add(profile.Telephone);
                item.SubItems.Add(profile.Role.ToString());
                listViewProfile.Items.Add(item);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var updateForm = new Validator.UpdateProfileForm()
            {
                Name = txBProfileName.Text,
                Telephone = txBProfileTelephone.Text
            };
            try
            {
                administrationService.Update(new Profile
                {
                    Id = long.Parse(listViewProfile.SelectedItems[0].SubItems[0].Text),
                    Name = updateForm.Name,
                    Telephone = updateForm.Telephone
                });
                LoadProfileLists();
                MessageBox.Show("Profile updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadTeacherList()
        {
            listViewTeacher.Items.Clear();
            administrationService.teachers().ForEach(t =>
            {
                ListViewItem item = new ListViewItem(t.Id.ToString());
                item.SubItems.Add(t.Profile.Name);
                item.SubItems.Add(t.Salary.Amount.ToString());
                item.SubItems.Add(t.Salary.Month.ToString());
                t.Subjects.ForEach(subject =>
                {
                    item.SubItems.Add(subject.Name);
                });
                listViewTeacher.Items.Add(item);
            });
        }
        private void listViewProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProfile.SelectedItems.Count > 0)
            {
                var selectedProfile = listViewProfile.SelectedItems[0];
                txBProfileName.Text = selectedProfile.SubItems[1].Text;
                txBProfileTelephone.Text = selectedProfile.SubItems[3].Text;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void listViewTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeacher.SelectedItems.Count > 0)
            {
                var selectedTeacher = listViewTeacher.SelectedItems[0];
                txBSalary.Text = selectedTeacher.SubItems[2].Text;
                txBMonth.Text = selectedTeacher.SubItems[3].Text;
            }
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                var teacher = administrationService.teachers().Find(t => t.Id == long.Parse(listViewTeacher.SelectedItems[0].SubItems[0].Text));
                if (!teacher.Equals(null))
                {
                    teacher.Salary.Month = byte.Parse(txBMonth.Text);
                    teacher.Salary.Amount = decimal.Parse(txBSalary.Text);
                }
                administrationService.UpdateTeachingStaff(teacher);
                LoadTeacherList();
                MessageBox.Show("Profile updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAdminList()
        {
            try
            {
                listViewAdmin.Items.Clear();
                administrationService.administrations().ForEach(a =>
                {
                    ListViewItem item = new ListViewItem(a.Id.ToString());
                    item.SubItems.Add(a.Profile.Name);
                    item.SubItems.Add(a.Salary.Amount.ToString());
                    item.SubItems.Add(a.Salary.Month.ToString());
                    item.SubItems.Add(a.Status.ToString());
                    item.SubItems.Add(a.WorkingHours.ToString());
                    listViewAdmin.Items.Add(item);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listViewAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdmin.SelectedItems.Count > 0)
            {
                var selectedAdmin = listViewAdmin.SelectedItems[0];
                txBAdminMonth.Text = selectedAdmin.SubItems[3].Text;
                txBAdminSalary.Text = selectedAdmin.SubItems[2].Text;
                cbBAdminStatus.Text = selectedAdmin.SubItems[4].Text;
                txBAdminWrkHrs.Text = selectedAdmin.SubItems[5].Text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var admin = administrationService.administrations().Find(t => t.Id == long.Parse(listViewAdmin.SelectedItems[0].SubItems[0].Text));
                if (!admin.Equals(null))
                {
                    admin.Salary.Month = byte.Parse(txBAdminMonth.Text);
                    admin.Salary.Amount = decimal.Parse(txBAdminSalary.Text);
                    admin.Status = cbBAdminStatus.SelectedItem.ToString();
                    admin.WorkingHours = int.Parse(txBAdminWrkHrs.Text);
                    administrationService.UpdateAdministration(admin);
                }
                LoadAdminList();
                MessageBox.Show("Profile updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
