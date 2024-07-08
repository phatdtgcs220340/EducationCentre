using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.models
{
    public abstract class Person
    {
        public Person(int id, Profile profile) { 
            this.Id = id;
            this.Profile = profile;
        }
        public int Id { get; }
        public Profile Profile { get; }
    }
    public class Student : Person
    {
        public Student(int id, Profile profile) : base(id, profile)
        {
            this.Profile.Role = Role.Student;
        }
    }
    public class TeachingStaff : Person
    {
        public TeachingStaff(int id, Profile profile) : base(id, profile)
        {
            this.Profile.Role = Role.TeachingStaff;
        }
    }
    public class Administration : Person
    {
        public Administration(int id, Profile profile) : base(id, profile)
        {
            this.Profile.Role = Role.Administration;
        }
    }
}
