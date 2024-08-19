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
    public class StudentRepository : RoleRepository<Student>
    {
        void Repository<Student>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        List<Student> Repository<Student>.FindAll()
        {
            string statement = @"
            WITH RankedSubjects AS (
                SELECT 
                    ss.student_id, 
                    sub.name AS subject_name, 
                    ss.date_started, 
                    p.name AS student_name, 
                    ROW_NUMBER() OVER (PARTITION BY ss.student_id ORDER BY ss.date_started DESC) AS subject_rank
                FROM 
                    subject_student ss
                JOIN 
                    student s ON ss.student_id = s.id
                JOIN 
                    subject sub ON ss.subject_id = sub.id
                JOIN 
                    profile p ON s.profile_id = p.id
            )
            SELECT 
                student_id, 
                subject_name, 
                student_name, 
                date_started
            FROM 
                RankedSubjects
            WHERE 
                subject_rank <= 4
            UNION

            SELECT 
                s.id AS student_id,
                NULL AS subject_name, 
                p.name AS student_name,
                NULL AS date_started 
            FROM 
                Student s
            JOIN 
                profile p ON p.id = s.profile_id
            ORDER BY 
                student_id,
                subject_name;
            ";

            return RepositoryExtension.Function(statement, (command) =>
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Student> students = new List<Student>();
                    while (reader.Read())
                    {
                        Student student = students.Find(s => s.Id == reader.GetInt32(reader.GetOrdinal("student_id")));
                        if (student == null)
                        {
                            student = new Student
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("student_id")),
                                Profile = new Profile
                                {
                                    Name = reader.GetString(reader.GetOrdinal("student_name"))
                                },
                                Subjects = new List<Subject>()
                            };
                            students.Add(student);
                        }
                        if (!reader.IsDBNull(reader.GetOrdinal("subject_name")))
                            student.Subjects.Add(new Subject
                            {
                                Name = reader.GetString(reader.GetOrdinal("subject_name")),
                                DateStarted = reader.GetDateTime(reader.GetOrdinal("date_started"))
                            });
                    }
                    return students;
                }
            });
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

        public Subject registerSubject(long studentId, long subjectId)
        {
            string statement = "INSERT INTO subject_student (student_id, subject_id) VALUES (@student_id, @subject_id)";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@student_id", studentId);
                command.Parameters.AddWithValue("@subject_id", subjectId);
                command.ExecuteNonQuery();
                return new Subject(); // nothing to return
            });
        }

        public Subject unregisterSubject(long studentId, long subjectId)
        {
            string statement = "DELETE FROM subject_student " +
                "WHERE student_id = @student_id AND subject_id = @subject_id";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@student_id", studentId);
                command.Parameters.AddWithValue("@subject_id", subjectId);
                command.ExecuteNonQuery();
                return new Subject(); // nothing to return
            });
        }
        public List<Subject> Subjects(long studentId)
        {
            string statement = "SELECT ss.student_id, ss.date_started, s.name, s.id " +
                "FROM Subject s " +
                "LEFT JOIN (SELECT ss.* " +
                "FROM subject_student ss " +
                "JOIN Subject s " +
                "ON ss.subject_id = s.id " +
                "WHERE ss.student_id = @student_id) ss " +
                "ON s.id = ss.subject_id " +
                "ORDER BY date_started DESC";

            return RepositoryExtension.Function(statement, (command) =>{
                command.Parameters.AddWithValue("@student_id", studentId);
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

        Student RoleRepository<Student>.FindByProfile(long profileId)
        {
            string statement = "SELECT s.*, p.* " +
                "FROM Student s LEFT JOIN Profile p " +
                "ON s.profile_id = p.id " +
                "WHERE s.profile_id = @profile_id";
            return RepositoryExtension.Function(statement, (command) =>
            {
                command.Parameters.AddWithValue("@profile_id", profileId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Profile = new Profile
                            {
                                Email = reader.GetString(reader.GetOrdinal("email")),
                                Id = reader.GetInt32(reader.GetOrdinal("profile_id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Telephone = reader.GetString(reader.GetOrdinal("telephone")),
                                Role = (Role)Enum.Parse(typeof(Role), reader.GetString(reader.GetOrdinal("role")))
                            }
                        };
                    }
                    throw new CustomException("Profile not found", CustomExceptionType.ProfileNotFound);
                }
            });
        }
    }
}
