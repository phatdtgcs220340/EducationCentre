using EducationCentre.constants;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EducationCentre.Validator
{
    public class RegisterForm
    {
        private string email;
        private string password;
        private string name;
        private string telephone;
        private string role;
        public string Email {
            get { return email; }
            set {
                if (value != null && value.Length != 0 && Regex.IsMatch(value, CommonRegex.EmailRegex))
                    email = value;
                else 
                    throw new Exception("Invalid email format");
            } 
        }
        public string Password {
            get { return password; }
            set { 
                if (value != null && value.Length != 0 && Regex.IsMatch(value, CommonRegex.PasswordRegex))
                    password = value;
                else 
                    throw new Exception("Invalid password format");
            }
        }
        public string Name { 
            get { return name; } 
            set {
                if (value.Length <= 100 && value != null && value.Length > 0)
                    name = value;
                else 
                    throw new Exception("Invalid name");
            }
        }
        public string Telephone { 
            get { return telephone; } 
            set { 
                if (value.Length != 0 && value != null && Regex.IsMatch(value, CommonRegex.TelephoneRegex))
                    telephone = value;
                else 
                    throw new Exception("Invalid telephone number");
            }
        }
    }
    public class LoginForm
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UpdateProfileForm
    {
        private string name;
        private string telephone;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 100 && value != null && value.Length > 0)
                    name = value;
                else
                    throw new Exception("Invalid name");
            }
        }
        public string Telephone
        {
            get { return telephone; }
            set
            {
                if (value.Length != 0 && value != null && Regex.IsMatch(value, CommonRegex.TelephoneRegex))
                    telephone = value;
                else
                    throw new Exception("Invalid telephone number");
            }
        }
    }
}
