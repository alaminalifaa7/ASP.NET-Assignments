using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_6.Data;
using Autofac;
namespace Assignment_6.Models
{
    public class CourseModel
    {
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public int Fee { get; set; }

        public void CreateCourse()
        {
            var context = Startup.AutofacContainer.Resolve<SchoolContext>();
            context.Courses.Add(new Course
            {
                Title = this.Title,
                SeatCount = this.SeatCount,
                Fee = this.Fee
            });

            context.SaveChanges();
          //  context.Dispose();
        }

    }
}
