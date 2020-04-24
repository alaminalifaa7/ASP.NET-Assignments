using Assignment_6.Models;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Data
{
    public class AutofacModule :Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public AutofacModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
           

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .InstancePerLifetimeScope();


            base.Load(builder);
        }
    }
}
