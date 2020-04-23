using Assignment_6.Data;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class StudentModel
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public void CreateStudent()
        {
            var context = Startup.AutofacContainer.Resolve<SchoolContext>();
            context.Students.Add(new Student
            {
                Name = this.Name,
                DateOfBirth = this.DateOfBirth
            });

            context.SaveChanges();
            context.Dispose();
        }
    }
}
