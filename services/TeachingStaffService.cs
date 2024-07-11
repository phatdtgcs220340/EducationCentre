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
    }
}
