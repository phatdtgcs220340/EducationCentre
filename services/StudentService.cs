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
        public List<Student> FindAll()
        {
            return studentRepository.FindAll();
        }
        public void registerSubject(long studentId, long subjectId)
        {
            ((StudentRepository)studentRepository).registerSubject(studentId, subjectId);
        }

        public void unregisterSubject(long studentId, long subjectId)
        {
            ((StudentRepository)studentRepository).unregisterSubject(studentId, subjectId);
        }

        public List<Subject> Subjects(long id)
        {
            return ((StudentRepository)studentRepository).Subjects(id);
        }
    }
}
