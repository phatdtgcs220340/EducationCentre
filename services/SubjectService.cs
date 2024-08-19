using EducationCentre.context;
using EducationCentre.models;
using EducationCentre.repositories;
using EducationCentre.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.services
{
    public class SubjectService
    {
        private readonly Repository<Subject> subjectRepository;

        public SubjectService()
        {
            subjectRepository = RepositoryFactory.GetRepository<Subject>(RepositoryType.Subject);
        }
        public List<Subject> FindAll()
        {
            return subjectRepository.FindAll();
        }
        public Subject Save(Subject model)
        {
            try
            {
                ((SubjectRepository)subjectRepository).FindByName(model.Name);
                throw new Exception("This subject has already existed!");
            }
            catch (CustomException)
            {
                return subjectRepository.Save(model);
            }
        }
        public void Delete(long id)
        {
            try
            {
                subjectRepository.FindById(id); // check if subject exists  
                subjectRepository.Delete(id);
            }
            catch (CustomException)
            {
                throw new CustomException("Subject not found", CustomExceptionType.SubjectNotFound);
            }
        }
    }
}
