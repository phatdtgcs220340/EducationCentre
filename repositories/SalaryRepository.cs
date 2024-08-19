using EducationCentre.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    public class SalaryRepository : Repository<Salary>
    {
        void Repository<Salary>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Salary> Repository<Salary>.FindAll()
        {
            throw new NotImplementedException();
        }

        Salary Repository<Salary>.FindById(long id)
        {
            throw new NotImplementedException();
        }

        Salary Repository<Salary>.Save(Salary model)
        {
            string statement = "INSERT INTO Salary (amount, month) VALUES (@Amount, @Month);"+
                "SELECT SCOPE_IDENTITY();";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Amount", model.Amount);
                command.Parameters.AddWithValue("@Month", model.Month);
                model.Id = Convert.ToInt32(command.ExecuteScalar());
                return model;
            });
        }

        public Salary Update(Salary salary)
        {
            string statement = "UPDATE Salary SET amount = @Amount, month = @Month WHERE id = @Id";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Amount", salary.Amount);
                command.Parameters.AddWithValue("@Month", salary.Month);
                command.Parameters.AddWithValue("@Id", salary.Id);
                command.ExecuteNonQuery();
                return salary;
            });
        }
    }
}
