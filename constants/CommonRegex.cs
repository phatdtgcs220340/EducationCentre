using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.constants
{
    public class CommonRegex
    {
        public readonly static string EmailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public readonly static string PasswordRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$";
        public readonly static string TelephoneRegex = @"^(\+\d{1,3}[- ]?)?\d{10}$";
    }
}
