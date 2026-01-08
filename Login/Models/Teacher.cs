using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    public class Teacher : Subject
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeacherSchoolID { get; set; }
        public string Password { get; set; }
        public int Percentage { get; set; }
    }
}
