using EducationCentre.configuration;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    public delegate T IFunction<T>(SqlCommand command);
    public interface Repository<T>
    {
        T Save(T model);
        void Delete(long id);
        List<T> FindAll();
        T FindById(long id);
    }

    public interface RoleRepository<T> : Repository<T>
    {
        T FindByProfile(long profileId);
    }
    // Interface extension method class
    public static class RepositoryExtension
    {
        public static T Function<T>(string statement, IFunction<T> function)
        {
            try
            {
                T result;
                using (SqlConnection connection = new SqlConnection(SqlConfiguration.LoadSqlServerSettings()))
                {
                    using (SqlCommand command = new SqlCommand(statement, connection))
                    {
                        connection.Open();
                        result = function(command);
                    }
                }
                return result;
            }
            catch (SqlException e)
            {
                throw new Exception(e.ToString());
            }
        }
    }
}