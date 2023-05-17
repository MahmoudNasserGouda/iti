using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5
{
    public class DatabaseStorage : DbContext
    {
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Employee> Employees{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ITI");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
