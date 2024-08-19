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
    public partial class StudentForm : Form
    {
        private Person currentUser = AuthenticationContext.Authentication;
        private SubjectService subjectService = ServiceFactory.GetService<SubjectService>(ServiceType.Subject);
        private StudentService studentService = ServiceFactory.GetService<StudentService>(ServiceType.Student);
        private List<Subject> subjects;
        public StudentForm()
        {
            InitializeComponent();
            refreshSubjects();
            loadRecentSubjects();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStudentAssign_Click(object sender, EventArgs e)
        {
            if (listViewStudentSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to register!");
                return;
            }
            else
            {
                var selectedSubject = listViewStudentSubject.SelectedItems[0];
                try
                {
                    studentService.registerSubject(currentUser.Id, long.Parse(selectedSubject.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You have already registered for this subject!");
                    return;
                }
                refreshSubjects();
                loadRecentSubjects();
                MessageBox.Show("Registered successfully!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewStudentSubject.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a subject to unregister!");
                return;
            }
            else
            {
                var selectedSubject = listViewStudentSubject.SelectedItems[0];
                studentService.unregisterSubject(currentUser.Id, long.Parse(selectedSubject.Text));
                refreshSubjects();
                loadRecentSubjects();
                MessageBox.Show("Unregistered successfully!");
            }
        }
        private void refreshSubjects()
        {
            subjects = studentService.Subjects(currentUser.Id);
            listViewStudentSubject.Items.Clear();
            subjects.ForEach(subject =>
            {
                ListViewItem item = new ListViewItem(subject.Id.ToString());
                item.SubItems.Add(subject.Name);
                item.SubItems.Add(subject.DateStarted.HasValue ? "Studied" : "-");
                listViewStudentSubject.Items.Add(item);
            });
        }
        private void loadRecentSubjects()
        {
            var studiedSubjects = subjects.FindAll(s => s.DateStarted.HasValue);
            if (studiedSubjects.Count < 4)
            {
                // Create a new list with 4 empty elements
                var emptySubjects = new List<Subject>(new Subject[4]);
                // Copy the elements from 'subjects' to the end of 'emptySubjects'
                for (int i = 0; i < studiedSubjects.Count; i++)
                    emptySubjects[i] = studiedSubjects[i];
                studiedSubjects = emptySubjects;
            }
            var text = String.Format("Current subjects: {0}, {1}\nPrevious subjects: {2}, {3}",
                studiedSubjects[0]?.Name, studiedSubjects[1]?.Name, studiedSubjects[2]?.Name, studiedSubjects[3]?.Name);
            lblShowSubjects.Text = text;
        }

        private void tabPageStudentSubject_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
