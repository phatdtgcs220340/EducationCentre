using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public Profile Profile { get; set; }
    }
    public class Student : Person
    {
        public List<Subject> Subjects { get; }
    }
    public class TeachingStaff : Person
    {
        public List<Subject> Subjects { get; }
        public Salary Salary { get; set; }
    }
    public class Administration : Person
    {
        public Salary Salary { get; set; }
        public string Status { get; set; }
    }
}
