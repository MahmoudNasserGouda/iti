using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class DataContext :DbContext
    {
        public DataContext() :base("name=CodeFirstDemoConnection")
        {

        }
        public DataContext(string connection):base(connection)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        //Using Fluent API
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Department>().ToTable("Dept");
            //modelBuilder.Entity<Department>().Property(d => d.Name).IsOptional();

            //modelBuilder.Entity<Employee>().ToTable("Emp");

            modelBuilder.Configurations.Add(new DepartmentConfiguration());



        }
    }
}
