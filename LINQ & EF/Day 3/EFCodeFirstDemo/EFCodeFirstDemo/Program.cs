using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext();

            #region Strategy 

            //Development Stage 
            //Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());

            //Release Stage 
            Database.SetInitializer<DataContext>(new MigrateDatabaseToLatestVersion<DataContext,Migrations.Configuration>());

            #endregion


            #region creating DB

            //Department Dept = new Department() { Name = "Dept1" };
            ////Department Dept2 = new Department() { Name = "Dept2" };
            //context.Departments.Add(Dept);
            ////context.Departments.Add(Dept2);

            //context.SaveChanges(); 


            #endregion


            #region Relations

            Department Dept = new Department { Name = "Dep1", Count = 1 };
            Address Add = new Address();
            Employee employee = new Employee() { Name = "Emp1", Salary = 2000 , Department=Dept , Address=Add};
            Employee employee2 = new Employee() { Name = "Emp2", Salary = 2000 , Department=Dept};

            context.Employees.Add(employee2);
            //context.Employees.Add(employee2);
            context.SaveChanges();

            #endregion
        }
    }
}
