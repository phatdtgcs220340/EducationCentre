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
    public class SalaryService
    {
        private Repository<Salary> salaryRepository;
        public SalaryService()
        {
            salaryRepository = RepositoryFactory.GetRepository<Salary>(RepositoryType.Salary);
        }

        public Salary Save(Salary model)
        {
            return salaryRepository.Save(model);
        }
    }
}
