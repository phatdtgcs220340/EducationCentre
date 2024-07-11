using EducationCentre.context;
using EducationCentre.models;
using EducationCentre.services;

namespace EducationCentre
{
    
    public partial class Form1 : Form
    {
        private AuthenticationService authenticationService = ServiceFactory.GetService<AuthenticationService>(ServiceType.Authentication);
        private StudentService studentService = ServiceFactory.GetService<StudentService>(ServiceType.Student);
        private AdministrationService administrationService = ServiceFactory.GetService<AdministrationService>(ServiceType.Administration);
        private TeachingStaffService teachingStaffService = ServiceFactory.GetService<TeachingStaffService>(ServiceType.TeachingStaff);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {               
            Profile profile = authenticationService.Register(new Profile
            {
                Email = "ddtphat204_teacher@gmail.com",
                Password = "hahaha998989",
                Role = Role.TeachingStaff,
                Name = "Phat",
                Telephone = "123456789"
            });

            switch (profile.Role) {
                case Role.Student:
                    studentService.Save(new Student
                    {
                        Profile = profile
                    });
                    break;
                case Role.TeachingStaff:
                    teachingStaffService.Save(new TeachingStaff
                    {
                        Profile = profile
                    });
                    break;
                case Role.Administration:
                    administrationService.Save(new Administration
                    {
                        Profile = profile
                    });
                    break;
            };
        }
    }
}
