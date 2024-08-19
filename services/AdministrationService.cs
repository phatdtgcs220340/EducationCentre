using EducationCentre.context;
using EducationCentre.models;
using EducationCentre.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.services
{
    public class AdministrationService
    {
        private readonly Repository<Administration> administrationRepository;
        private readonly Repository<Salary> salaryRepository;
        private readonly Repository<Profile> profileRepository;
        private readonly Repository<Student> studentRepository;
        private readonly Repository<TeachingStaff> teachingStaffRepository;
        public AdministrationService() { 
            administrationRepository = RepositoryFactory.GetRepository<Administration>(RepositoryType.Administration);
            salaryRepository = RepositoryFactory.GetRepository<Salary>(RepositoryType.Salary);
            profileRepository = RepositoryFactory.GetRepository<Profile>(RepositoryType.Profile);
            studentRepository = RepositoryFactory.GetRepository<Student>(RepositoryType.Student);
            teachingStaffRepository = RepositoryFactory.GetRepository<TeachingStaff>(RepositoryType.TeachingStaff);
        }

        public List<Profile> profiles()
        {
            return profileRepository.FindAll();
        }
        public List<Student> students()
        {
            return studentRepository.FindAll();
        }

        public void Update(Profile profile)
        {
           ((ProfileRepository)profileRepository).Update(profile);
        }
        public void UpdateTeachingStaff(TeachingStaff teachingStaff)
        {
            ((SalaryRepository)salaryRepository).Update(teachingStaff.Salary);
        }
        public void UpdateAdministration(Administration administration)
        {
            ((SalaryRepository)salaryRepository).Update(administration.Salary);
            ((AdminstrationRepository)administrationRepository).Update(administration);
        }
        public List<TeachingStaff> teachers()
        {
            return teachingStaffRepository.FindAll();
        }
        public List<Administration> administrations()
        {
            return administrationRepository.FindAll();
        }
    }
}
