using EducationCentre.models;
using EducationCentre.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.context
{
    public enum RepositoryType
    {
        Student,
        Administration,
        TeachingStaff,
        Profile
    }
    
    /**
     * @brief : A class that manages the repository objects
     * @author : Phat Do
     */
    public class RepositoryFactory
    {
        private readonly static Dictionary<RepositoryType, object> repositories = new Dictionary<RepositoryType, object>() 
        {
            { RepositoryType.Student, new StudentRepository() },
            { RepositoryType.Administration, new AdminstrationRepository() },
            { RepositoryType.TeachingStaff, new TeachingStaffRepository() },
            { RepositoryType.Profile, new ProfileRepository() }
        };

        public static Repository<T> GetRepository<T>(RepositoryType type)
        {
            return (Repository<T>)repositories[type];
        }
    }
}
