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
    public class TeachingStaffRepository : RoleRepository<TeachingStaff>
    {
        void Repository<TeachingStaff>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        List<TeachingStaff> Repository<TeachingStaff>.FindAll()
        {
            string statement = @"
            WITH RankedSubjects AS (
            SELECT 
                st.teacher_id,
                sub.name AS subject_name,
                p.name AS teacher_name,
                s.amount AS salary_amount,
                s.id AS salary_id,
                s.month,
                st.date_started,
                ROW_NUMBER() OVER (PARTITION BY st.teacher_id ORDER BY st.date_started DESC) AS subject_rank
            FROM 
                subject_teacher st
            JOIN 
                TeachingStaff t ON st.teacher_id = t.id
            JOIN 
                profile p ON p.id = t.profile_id
            JOIN 
                subject sub ON st.subject_id = sub.id
            JOIN 
                salary s ON s.id = t.salary_id
        )
        SELECT 
            teacher_id,
            subject_name,
            salary_amount,
            month,
            salary_id,
            teacher_name,
            date_started
        FROM 
            RankedSubjects
        WHERE 
            subject_rank <= 2

        UNION

        SELECT 
            t.id AS teacher_id,
            NULL AS subject_name, 
            s.amount AS salary_amount,
            s.month,
            s.id AS salary_id,
            p.name AS teacher_name,
            NULL AS date_started 
        FROM 
            TeachingStaff t
        JOIN 
            profile p ON p.id = t.profile_id
        JOIN 
            salary s ON s.id = t.salary_id
        ORDER BY 
            teacher_id,
            subject_name;

            ";
            return RepositoryExtension.Function(statement, (command) =>
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<TeachingStaff> teachers = new List<TeachingStaff>();
                    while (reader.Read())
                    {
                        var teacher = teachers.Find(t => t.Id == reader.GetInt32(reader.GetOrdinal("teacher_id")));
                        if (teacher == null)
                        {
                            teacher = new TeachingStaff
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("teacher_id")),
                                Profile = new Profile
                                {
                                    Name = reader.GetString(reader.GetOrdinal("teacher_name"))
                                },
                                Salary = new Salary
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("salary_id")),
                                    Amount = reader.GetDecimal(reader.GetOrdinal("salary_amount")),
                                    Month = reader.GetByte(reader.GetOrdinal("month"))
                                },
                                Subjects = new List<Subject>()
                            };
                            teachers.Add(teacher);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("subject_name")))
                            teacher.Subjects.Add(new Subject
                            {
                                Name = reader.GetString(reader.GetOrdinal("subject_name")),
                                DateStarted = reader.GetDateTime(reader.GetOrdinal("date_started"))
                            });
                    }
                    return teachers;
                }
            });
        }

        TeachingStaff Repository<TeachingStaff>.FindById(long id)
        {
            throw new NotImplementedException();
        }

        TeachingStaff RoleRepository<TeachingStaff>.FindByProfile(long profileId)
        {
            string statement = "SELECT a.*, p.*, s.* " +
                "FROM TeachingStaff a " +
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
                        return new TeachingStaff
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
                            }
                        };
                    }
                    throw new CustomException("Profile not found", CustomExceptionType.ProfileNotFound);
                }
            });
        }

        TeachingStaff Repository<TeachingStaff>.Save(TeachingStaff model)
        {
            string statement = "INSERT INTO TeachingStaff (profile_id, salary_id) VALUES (@ProfileId, @SalaryId)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@ProfileId", model.Profile.Id);
                command.Parameters.AddWithValue("@SalaryId", model.Salary.Id);
                command.ExecuteNonQuery();
                return model;
            });
        }

        public List<Subject> Subjects(long teacherId)
        {
            string statement = "SELECT st.teacher_id, st.date_started, s.name, s.id " +
                "FROM Subject s " +
                "LEFT JOIN (SELECT st.* " +
                "FROM subject_teacher st " +
                "JOIN Subject s " +
                "ON st.subject_id = s.id " +
                "WHERE st.teacher_id = @teacher_id) st " +
                "ON s.id = st.subject_id " +
                "ORDER BY date_started DESC";

            return RepositoryExtension.Function(statement, (command) => {
                command.Parameters.AddWithValue("@teacher_id", teacherId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Subject> subjects = new List<Subject>();
                    while (reader.Read())
                    {
                        var dateOrdinal = reader.GetOrdinal("date_started");
                        subjects.Add(!reader.IsDBNull(dateOrdinal) ? new Subject
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            DateStarted = reader.GetDateTime(dateOrdinal)
                        } : new Subject
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name"))
                        });
                    }
                    return subjects;
                }
            });
        }
        public Subject registerSubject(long teacherId, long subjectId)
        {
            string statement = "INSERT INTO subject_teacher (teacher_id, subject_id) VALUES (@teacher_id, @subject_id)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@teacher_id", teacherId);
                command.Parameters.AddWithValue("@subject_id", subjectId);
                command.ExecuteNonQuery();
                return new Subject(); // nothing to return
            });
        }
        public Subject unregisterSubject(long teacherId, long subjectId)
        {
            string statement = "DELETE FROM subject_teacher " +
                "WHERE teacher_id = @teacher_id AND subject_id = @subject_id";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@teacher_id", teacherId);
                command.Parameters.AddWithValue("@subject_id", subjectId);
                command.ExecuteNonQuery();
                return new Subject(); // nothing to return
            });
        }
    }
}
