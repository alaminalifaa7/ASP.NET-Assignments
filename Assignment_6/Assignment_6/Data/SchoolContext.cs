using Assignment_6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Data
{
    public class SchoolContext : DbContext 
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public SchoolContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<StudentRegistration>()
                .HasKey(sr => new { sr.StudentId, sr.CourseId });

            builder.Entity<StudentRegistration>()
                .HasOne(sr => sr.Student)
                .WithMany(c => c.Courses)
                .HasForeignKey(sr => sr.StudentId);

            builder.Entity<StudentRegistration>()
                .HasOne(sr => sr.Course)
                .WithMany(c => c.Courses)
                .HasForeignKey(pc => pc.CourseId);


            base.OnModelCreating(builder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentRegistration> StudentRegistrations { get; set; }

    }
}
