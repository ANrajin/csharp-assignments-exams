using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task2.Entities;

namespace Task2.DBContexts
{
    class TrainingContext:DbContext
    {
        private readonly string _connectionString;

        private readonly string _assemblyName;

        public TrainingContext()
        {
            _connectionString = ConnectionStringReader.connectionString;
            _assemblyName = typeof(Program).Assembly.FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_assemblyName)
                );
            }

            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>().HasKey(en => new { en.CourseId, en.StudentId });
            builder.Entity<Enrollment>().HasOne(c => c.Course).WithMany(cs => cs.Enrollments).HasForeignKey(fk => fk.CourseId);
            builder.Entity<Enrollment>().HasOne(s => s.Student).WithMany(std => std.Enrollments).HasForeignKey(fk => fk.StudentId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
