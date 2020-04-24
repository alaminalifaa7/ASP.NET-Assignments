using Assignment_6.Data;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class StudentRepository :Student, IStudentRepository
    {


        //private readonly SchoolContext context;
        //public StudentRepository(SchoolContext context)
        //{
        //    this.context = context;
        //}
        public void AddStudent()
        {
            var context = Startup.AutofacContainer.Resolve<SchoolContext>();
            context.Students.Add(new Student
            {
                Name = this.Name,
                DateOfBirth = this.DateOfBirth
            });
            context.SaveChanges();
            
        }
    }
}
