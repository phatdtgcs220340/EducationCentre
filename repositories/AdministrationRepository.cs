using EducationCentre.exception;
using EducationCentre.models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    public class AdminstrationRepository : RoleRepository<Administration>
    {
        void Repository<Administration>.Delete(long id)
        {
            string statement = "DELETE FROM Administration WHERE id = @Id";
            RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                return new Administration();
            });
        }

        List<Administration> Repository<Administration>.FindAll()
        {
            string statement = "SELECT a.*, p.name, s.* " +
                "FROM Administration a " +
                "LEFT JOIN Profile p ON a.profile_id = p.id " +
                "LEFT JOIN Salary s ON a.salary_id = s.id";
            return RepositoryExtension.Function(statement, (command) =>{
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Administration> administrations = new List<Administration>();
                    while (reader.Read())
                    {
                        administrations.Add(new Administration
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Profile = new Profile
                            {
                                Name = reader.GetString(reader.GetOrdinal("name"))
                            },
                            Salary = new Salary
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("salary_id")),
                                Amount = reader.GetDecimal(reader.GetOrdinal("amount")),
                                Month = reader.GetByte(reader.GetOrdinal("month"))
                            },
                            Status = reader.GetString(reader.GetOrdinal("status")),
                            WorkingHours = reader.GetByte(reader.GetOrdinal("working_hours"))
                        });
                    }
                    return administrations;
                }
            });
        }

        Administration Repository<Administration>.FindById(long id)
        {
            throw new NotImplementedException();
        }

        Administration RoleRepository<Administration>.FindByProfile(long profileId)
        {
            string statement = "SELECT a.*, p.*, s.* " +
                "FROM Administration a " +
                "LEFT JOIN Profile p ON a.profile_id = p.id " +
                "LEFT JOIN Salary s ON a.salary_id = s.id " +
                "WHERE a.profile_id = @ProfileId";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@ProfileId", profileId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Administration
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Profile = new Profile
                            {
                                Email = reader.GetString(reader.GetOrdinal("email")),
                                Id = reader.GetInt32(reader.GetOrdinal("profile_id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Telephone = reader.GetString(reader.GetOrdinal("telephone")),
                                Role = (Role)Enum.Parse(typeof(Role), reader.GetString(reader.GetOrdinal("role")))
                            },
                            Salary = new Salary
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("salary_id")),
                                Amount = reader.GetDecimal(reader.GetOrdinal("amount")),
                                Month = reader.GetByte(reader.GetOrdinal("month"))
                            },
                            Status = reader.GetString(reader.GetOrdinal("status")),
                            WorkingHours = reader.GetByte(reader.GetOrdinal("working_hours"))
                        };
                    }
                    throw new CustomException("Profile not found", CustomExceptionType.ProfileNotFound);
                }
            });
        }

        Administration Repository<Administration>.Save(Administration model)
        {
            string statement = "INSERT INTO Administration (profile_id, salary_id, status, working_hours) VALUES (@ProfileId, @SalaryId, @Status, @WorkingHours)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@ProfileId", model.Profile.Id);
                command.Parameters.AddWithValue("@SalaryId", model.Salary.Id);
                command.Parameters.AddWithValue("@Status", model.Status);   
                command.Parameters.AddWithValue("@WorkingHours", model.WorkingHours);
                command.ExecuteNonQuery();
                return model;
            });
        }
        public void Update(Administration model)
        {
            string statement = "UPDATE Administration SET status = @Status, working_hours = @WorkingHours WHERE id = @Id";
            RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Status", model.Status);
                command.Parameters.AddWithValue("@WorkingHours", model.WorkingHours);
                command.Parameters.AddWithValue("@Id", model.Id);
                command.ExecuteNonQuery();
                return model;
            });
        }
    }

}
