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
    public class StudentRepository : Repository<Student>
    {
        void Repository<Student>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Student> Repository<Student>.FindAll()
        {
            //string statement = "SELECT s.*, p.* " +
            //    "FROM Student s LEFT JOIN Profile p" +
            //    "ON s.profile_id = p.id";
            //return RepositoryExtension.Function(statement, (command) =>
            //{
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        List<Student> students = new List<Student>();
            //        while (reader.Read())
            //        {
            //            students.Add(new Student
            //            {
            //                Id = reader.GetInt64(reader.GetOrdinal("Id")),
            //                Name = reader.GetString(reader.GetOrdinal("Name")),
            //                Email = reader.GetString(reader.GetOrdinal("Email")),
            //                Telephone = reader.GetString(reader.GetOrdinal("Telephone"))
            //            });
            //        }
            //        return students;
            //    }
            //});
            throw new NotImplementedException();
        }

        Student Repository<Student>.FindById(long id)
        {
            throw new NotImplementedException();
        }

        public Student Save(Student model)
        {
            string statement = "INSERT INTO Student (profile_id) VALUES (@profile_id)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@profile_id", model.Profile.Id);
                command.ExecuteNonQuery();
                return model;
            });
        }
    }

    public class AdminstrationRepository : Repository<Administration>
    {
        void Repository<Administration>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Administration> Repository<Administration>.FindAll()
        {
            throw new NotImplementedException();
        }

        Administration Repository<Administration>.FindById(long id)
        {
            throw new NotImplementedException();
        }

        Administration Repository<Administration>.Save(Administration model)
        {
            string statement = "INSERT INTO Administration (profile_id) VALUES (@profile_id)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@profile_id", model.Profile.Id);
                command.ExecuteNonQuery();
                return model;
            });
        }
    }

    public class TeachingStaffRepository : Repository<TeachingStaff>
    {
        void Repository<TeachingStaff>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        List<TeachingStaff> Repository<TeachingStaff>.FindAll()
        {
            throw new NotImplementedException();
        }

        TeachingStaff Repository<TeachingStaff>.FindById(long id)
        {
            throw new NotImplementedException();
        }

        TeachingStaff Repository<TeachingStaff>.Save(TeachingStaff model)
        {
            string statement = "INSERT INTO TeachingStaff (profile_id) VALUES (@profile_id)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@profile_id", model.Profile.Id);
                command.ExecuteNonQuery();
                return model;
            });
        }
    }
}
