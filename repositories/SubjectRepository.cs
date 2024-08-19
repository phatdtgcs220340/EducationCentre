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
    public class SubjectRepository : Repository<Subject>
    {
        void Repository<Subject>.Delete(long id)
        {
            string statement = "DELETE FROM Subject WHERE id = @Id";
            RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                return new Subject();
            });
        }

        List<Subject> Repository<Subject>.FindAll()
        {
            string statement = "SELECT * FROM Subject";
            return RepositoryExtension.Function(statement, (command) =>
            {
                using (var reader = command.ExecuteReader())
                {
                    List<Subject> subjects = new List<Subject>();
                    while (reader.Read())
                        subjects.Add(new Subject
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            DateCreated = reader.GetDateTime(reader.GetOrdinal("date_created"))
                        });
                    return subjects;
                }
            });
        }

        Subject Repository<Subject>.FindById(long id)
        {
            string statement = "SELECT * FROM Subject WHERE id = @Id;";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.Read())
                        return new Subject
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            DateCreated = reader.GetDateTime(reader.GetOrdinal("date_created"))
                        };
                    else throw new CustomException("Subject not found", CustomExceptionType.SubjectNotFound);
            });
        }

        Subject Repository<Subject>.Save(Subject model)
        {
            string statement = "INSERT INTO Subject (name) VALUES (@Name);"
                + "SELECT SCOPE_IDENTITY();";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Name", model.Name);
                model.Id = Convert.ToInt32(command.ExecuteScalar());
                return model;
            });
        }

        public Subject FindByName(string name)
        {
            string statement = "SELECT * FROM Subject WHERE name = @Name";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Name", name);
                using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.Read())
                        return new Subject
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name"))
                        };
                    else throw new CustomException("Subject not found", CustomExceptionType.SubjectNotFound);
            });
        }
    }
}
