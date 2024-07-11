using EducationCentre.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.context
{
    /**
     * @brief : A class that stores the authentication context
     */
    public class AuthenticationContext
    {
        public static Profile Authentication { get; set; }
    }
}
