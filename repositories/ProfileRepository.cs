using EducationCentre.models;
using EducationCentre.exception;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.repositories
{
    /**
     * @brief : A class do the CRUD operations on Infrastructure layer for the Profile model
     */
    public class ProfileRepository : Repository<Profile>
    {
        void Repository<Profile>.Delete(long id)
        {
            string statement = "DELETE FROM Profile WHERE id = @Id";
            RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
                return new Profile();
            });
        }

        List<Profile> Repository<Profile>.FindAll()
        {
            string statement = "SELECT * FROM Profile";
            return RepositoryExtension.Function(statement, (command) =>
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Profile> profiles = new List<Profile>();
                    while (reader.Read())
                    {
                        profiles.Add(new Profile
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Email = reader.GetString(reader.GetOrdinal("email")),
                            Telephone = reader.GetString(reader.GetOrdinal("telephone")),
                            Role = (Role)Enum.Parse(typeof(Role), reader.GetString(reader.GetOrdinal("role")))
                        });
                    }
                    return profiles;
                }
            });
        }

        Profile Repository<Profile>.FindById(long id)
        {
            string statement = "SELECT * FROM Profile WHERE id = @Id";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                   if (reader.Read())
                        return new Profile

                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Telephone = reader.GetString(reader.GetOrdinal("Telephone")),
                            Role = (Role)Enum.Parse(typeof(Role), reader.GetString(reader.GetOrdinal("Role"))),
                            Password = reader.GetString(reader.GetOrdinal("Password"))
                        };
                   else 
                        throw new CustomException("Profile not found", CustomExceptionType.ProfileNotFound);
                }
            });
        }

        Profile Repository<Profile>.Save(Profile model)
        {
            string statement = 
                "INSERT INTO Profile (name, email, telephone, role, password) VALUES (@Name, @Email, @Phone, @Role, @Password);" +
                "SELECT SCOPE_IDENTITY();";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Phone", model.Telephone);
                command.Parameters.AddWithValue("@Role", model.Role.ToString());
                command.Parameters.AddWithValue("@Password", model.Password);
                var result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                    model.Id = id;
                return model;
            });
        }
        public Profile FindByEmail(string email)
        {
            string statement = "SELECT * FROM Profile WHERE email = @Email";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return new Profile
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Telephone = reader.GetString(reader.GetOrdinal("Telephone")),
                            Role = (Role)Enum.Parse(typeof(Role), reader.GetString(reader.GetOrdinal("Role"))),
                            Password = reader.GetString(reader.GetOrdinal("Password"))
                        };
                    else
                        throw new CustomException("Profile not found", CustomExceptionType.ProfileNotFound);
                }
            });
        }
    }
}
