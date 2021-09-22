using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Task2.Dbcontext
{
    public class TrainingContext:DbContext
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

                base.OnConfiguring(builder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
