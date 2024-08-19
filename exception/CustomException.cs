using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.exception
{
    public enum CustomExceptionType
    {
        ProfileNotFound,
        ProfileAlreadyExists,
        SubjectNotFound,
        SubjectAlreadyExists
    }
    public class CustomException : Exception
    {
        public CustomExceptionType Type { get; }
        public CustomException(String message, CustomExceptionType type) : base(message) {
            Type = type;
        }
    }
}
