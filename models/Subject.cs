using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationCentre.models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set;  }
        public DateTime? DateStarted { get; set; }
    }
}
