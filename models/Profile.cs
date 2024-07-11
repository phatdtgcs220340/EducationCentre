using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.models
{
    public enum Role
    {
        Student,
        TeachingStaff,
        Administration
    }
    public class Profile
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email {  get; set; }
        public Role Role { get; set; }
        public string Password { get; set; }
    }
}
