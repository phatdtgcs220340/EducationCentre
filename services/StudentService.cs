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
    public class StudentService
    {
        private readonly Repository<Student> studentRepository;
        public StudentService() { 
            studentRepository = RepositoryFactory.GetRepository<Student>(RepositoryType.Student);
        }
        public Student Save(Student model)
        {
            return studentRepository.Save(model);
        }
    }
}
