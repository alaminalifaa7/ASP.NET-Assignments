using Assignment_6.Data;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Models
{
    public class RegistrationModel
    {

        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public DateTime EnrollDate { get; set; }

        public bool isPaymentComplete { get; set; }

        public void CreateRegistration()
        {
            var context = Startup.AutofacContainer.Resolve<SchoolContext>();
            context.StudentRegistrations.Add(new StudentRegistration
            {
                StudentId = this.StudentId,
                CourseId = this.CourseId,
                EnrollDate = this.EnrollDate,
                isPaymentComplete =this.isPaymentComplete

            });

            context.SaveChanges();
            //  context.Dispose();
        }
    }
}
