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
        public AdministrationService() { 
            administrationRepository = RepositoryFactory.GetRepository<Administration>(RepositoryType.Administration);
        }
        public Administration Save(Administration model)
        {
            return administrationRepository.Save(model);
        }
    }
}
