using EducationCentre.services;
using EducationCentre.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EducationCentre.models;

namespace EducationCentre
{
    public partial class TeacherForm : Form
    {
        private Person currentUser = AuthenticationContext.Authentication;
        private TeachingStaffService teacherService = ServiceFactory.GetService<TeachingStaffService>(ServiceType.TeachingStaff);
        private List<Subject> subjects;
        public TeacherForm()
        {
            InitializeComponent();
            LoadSubjects();
            loadRecentSubjects();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (listViewTeacherSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to register!");
                return;
            }
            else
            {
                var selectedSubject = listViewTeacherSubject.SelectedItems[0];
                try
                {
                    teacherService.registerSubject(currentUser.Id, long.Parse(selectedSubject.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You have already registered for this subject!");
                    return;
                }
                LoadSubjects();
                loadRecentSubjects();
                MessageBox.Show("Registered successfully!");
            }
        }
        private void LoadSubjects()
        {
            subjects = teacherService.Subjects(currentUser.Id);
            listViewTeacherSubject.Items.Clear();
            subjects.ForEach(subject =>
            {
                ListViewItem item = new ListViewItem(subject.Id.ToString());
                item.SubItems.Add(subject.Name);
                item.SubItems.Add(subject.DateStarted.HasValue ? "Teached" : "-");
                listViewTeacherSubject.Items.Add(item);
            });
        }

        private void loadRecentSubjects()
        {
            var studiedSubjects = subjects.FindAll(s => s.DateStarted.HasValue);
            if (studiedSubjects.Count < 2)
            {
                var emptySubjects = new List<Subject>(new Subject[2]);
                for (int i = 0; i < studiedSubjects.Count; i++)
                    emptySubjects[i] = studiedSubjects[i];
                studiedSubjects = emptySubjects;
            }
            var text = String.Format("Current teaching: {0}, {1}",
                studiedSubjects[0]?.Name, studiedSubjects[1]?.Name);
            lblShowSubjects.Text = text;
        }

        private void btnUnRegister_Click(object sender, EventArgs e)
        {
            if (listViewTeacherSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to unregister!");
                return;
            }
            else
            {
                var selectedSubject = listViewTeacherSubject.SelectedItems[0];
                teacherService.unregisterSubject(currentUser.Id, long.Parse(selectedSubject.Text));
                LoadSubjects();
                loadRecentSubjects();
                MessageBox.Show("Unregistered successfully!");
            }
        }
    }
}
