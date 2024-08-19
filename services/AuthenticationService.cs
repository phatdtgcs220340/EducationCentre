using EducationCentre.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationCentre.models;
using EducationCentre.context;
using EducationCentre.exception;

namespace EducationCentre.services
{
    /**
     * A class that handles the authentication of the user
     */
    public class AuthenticationService
    {
        private readonly Repository<Profile> profileRepository;
        private readonly Repository<Student> studentRepository;
        private readonly Repository<Administration> adminstrationRepository;
        private readonly Repository<TeachingStaff> teachingStaffRepository;
        private readonly Repository<Salary> salaryRepository;   
        private readonly string salt = "$2a$04$z6b7Flr3i8.rglQIBi1u.OrIgQsjIFDWnJ5d2t0gbKAHVnAzHS7ma";

        public AuthenticationService() {
            profileRepository = RepositoryFactory.GetRepository<Profile>(RepositoryType.Profile);
            studentRepository = RepositoryFactory.GetRepository<Student>(RepositoryType.Student);
            adminstrationRepository = RepositoryFactory.GetRepository<Administration>(RepositoryType.Administration);
            teachingStaffRepository = RepositoryFactory.GetRepository<TeachingStaff>(RepositoryType.TeachingStaff);
            salaryRepository = RepositoryFactory.GetRepository<Salary>(RepositoryType.Salary);
        }

        public Person Login(string username, string password) { 
            Profile user = ((ProfileRepository) profileRepository).FindByEmail(username);
            
            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                switch (user.Role)
                 {
                    case Role.Administration:
                        return ((RoleRepository<Administration>)adminstrationRepository).FindByProfile(user.Id); // return an admin if the user is an admin
                    case Role.TeachingStaff:
                        return ((RoleRepository<TeachingStaff>)teachingStaffRepository).FindByProfile(user.Id); // return a teacher if the user is a teacher
                    case Role.Student:
                        return  ((RoleRepository<Student>)studentRepository).FindByProfile(user.Id); // return a student if the user is a student
                 }
            throw new Exception("Invalid password");
        }

        public void Register(Profile model)
        {
            try
            {
                ((ProfileRepository) profileRepository).FindByEmail(model.Email);
                throw new Exception("Profile already exists");
            }
            catch (CustomException) { // If the profile does not exist, save it
                model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password, salt);
                var profile = profileRepository.Save(model);
                Salary salary;
                switch (profile.Role)
                {
                    case Role.Administration:
                        salary = salaryRepository.Save(new Salary { Amount = 1000, Month = 1 });
                        adminstrationRepository.Save(new Administration
                        {
                            Profile = profile,
                            Salary = salary,
                            Status = "part-time",
                            WorkingHours = 8
                        });
                        break;
                    case Role.Student:
                        studentRepository.Save(new Student
                        {
                            Profile = profile
                        });
                        break;
                    case Role.TeachingStaff:
                        salary = salaryRepository.Save(new Salary { Amount = 500, Month = 1 });
                        teachingStaffRepository.Save(new TeachingStaff
                        {
                            Profile = profile,
                            Salary = salary
                        });
                        break;
                }
            }
        }
    }
}
