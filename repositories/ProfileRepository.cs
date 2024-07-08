using EducationCentre.configuration;
using EducationCentre.models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    public class ProfileRepository : Repository<Profile>
    {
        void Repository<Profile>.delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Profile> Repository<Profile>.findAll()
        {
            throw new NotImplementedException();
        }

        Profile Repository<Profile>.findById(long id)
        {
            throw new NotImplementedException();
        }

        Profile Repository<Profile>.save(Profile model)
        {
            throw new NotImplementedException();
        }
    }
}
