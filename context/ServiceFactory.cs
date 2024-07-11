using EducationCentre.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.context
{
    public enum ServiceType
    {
        Authentication,
        Student,
        Administration,
        TeachingStaff
    }   
    /**
     * @brief : A class that manages the service objects
     */
    public class ServiceFactory
    {
        private readonly static Dictionary<ServiceType, object> repositories = new Dictionary<ServiceType, object>()
        {
            { ServiceType.Authentication, new AuthenticationService() },
            { ServiceType.Student, new StudentService() },
            { ServiceType.Administration, new AdministrationService() },
            { ServiceType.TeachingStaff, new TeachingStaffService() }
        };

        public static T GetService<T>(ServiceType type)
        {
            return (T)repositories[type];
        }
    }
}
