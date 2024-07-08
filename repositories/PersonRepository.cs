using EducationCentre.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    public class StudentRepository : Repository<Student>
    {
        void Repository<Student>.delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Student> Repository<Student>.findAll()
        {
            throw new NotImplementedException();
        }

        Student Repository<Student>.findById(long id)
        {
            throw new NotImplementedException();
        }

        Student Repository<Student>.save(Student model)
        {
            throw new NotImplementedException();
        }
    }

    public class AdminstrationRepository : Repository<Administration>
    {
        void Repository<Administration>.delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Administration> Repository<Administration>.findAll()
        {
            throw new NotImplementedException();
        }

        Administration Repository<Administration>.findById(long id)
        {
            throw new NotImplementedException();
        }

        Administration Repository<Administration>.save(Administration model)
        {
            throw new NotImplementedException();
        }
    }

    public class TeachingStaffRepository : Repository<TeachingStaff>
    {
        void Repository<TeachingStaff>.delete(long id)
        {
            throw new NotImplementedException();
        }

        List<TeachingStaff> Repository<TeachingStaff>.findAll()
        {
            throw new NotImplementedException();
        }

        TeachingStaff Repository<TeachingStaff>.findById(long id)
        {
            throw new NotImplementedException();
        }

        TeachingStaff Repository<TeachingStaff>.save(TeachingStaff model)
        {
            throw new NotImplementedException();
        }
    }
}
