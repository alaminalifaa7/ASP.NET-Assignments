using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public IList<StudentRegistration> Courses { get; set; }
       
    }
}
