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
    public class TeachingStaffService
    {
        private readonly Repository<TeachingStaff> teachingStaffRepository;
        public TeachingStaffService() { 
            teachingStaffRepository = RepositoryFactory.GetRepository<TeachingStaff>(RepositoryType.TeachingStaff);
        }
        public TeachingStaff Save(TeachingStaff model)
        {
            return teachingStaffRepository.Save(model);
        }
        public List<Subject> Subjects(long id)
        {
            return ((TeachingStaffRepository)teachingStaffRepository).Subjects(id);
        }
        public void registerSubject(long teachingStaffId, long subjectId)
        {
            ((TeachingStaffRepository)teachingStaffRepository).registerSubject(teachingStaffId, subjectId);
        }
        public void unregisterSubject(long teachingStaffId, long subjectId)
        {
            ((TeachingStaffRepository)teachingStaffRepository).unregisterSubject(teachingStaffId, subjectId);
        }
    }
}
