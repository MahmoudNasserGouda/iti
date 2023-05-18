using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyEntities context = new CompanyEntities();
            context.Database.Log = l => Debug.WriteLine(l);


            #region Eager vs Deffered 

            //var Query = context.Departments.Select(d => d).ToList().Where(d => d.ID > 7);

            //foreach (var item in Query)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Insert

            //Department Dept = new Department() { ID = 19, Name = "TestEFDBFirst" };

            //context.Departments.Add(Dept);

            // context.Entry(Dept).State= System.Data.Entity.EntityState.Added; //inside SaveChanges

            context.SaveChanges();



            #endregion

            #region Update

            //var UpdateDept = context.Departments.FirstOrDefault();
            //UpdateDept.Name = "ay7agaaa.";
            //context.SaveChanges();

            #endregion

            #region Delete

            //var DeleteDept = context.Departments.FirstOrDefault();
            //context.Departments.Remove(DeleteDept);
            //context.SaveChanges();
            #endregion

            #region ay 7aga

            //context.Database.Log = l=> Debug.WriteLine(l);

            //var Query = from d in context.Departments.ToList()
            //            where d.ID == int.Parse("1")
            //            select d;

            //int x = int.Parse("1");
            //var Query = from d in context.Departments.ToList()
            //            where d.ID ==x
            //            select d;

            //foreach (var item in Query)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Relations


            //var Query = from e in context.Employees
            //            select new { e.Name, DeptName= e.Department.Name };
            //var Q = from d in context.Departments
            //        select new { d.Name, d.Employees };


            //foreach (var item in Q)
            //{
            //    Console.WriteLine(item.Name +".....");
            //    foreach (var e in item.Employees )
            //    {
            //        Console.WriteLine(e.Name);
            //    }
            //}


            //Department Dept = new Department() { ID = 23, Name = "TestRelations"  };

            //Employee Emp = new Employee() { Name = "TestRelation", Department = Dept };
            //Employee Emp2 = new Employee() { Name = "TestRelation", DeptID = 20 };//Error


            //context.Employees.Add(Emp2);


            //context.SaveChanges();

            #endregion

            #region Stored Procedure

            //foreach (var item in context.GetAllDepartments())
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Concurrncey Mode

            //CompanyEntities context2 = new CompanyEntities();

            //Employee Emp1 = context.Employees.FirstOrDefault();
            //Employee Emp2 = context2.Employees.FirstOrDefault();

            //Emp1.Salary -= 2000;

            //Emp2.Salary -= 1000;

            //context.SaveChanges();
            //try
            //{
            //    context2.SaveChanges();
            //}
            //catch (DbUpdateConcurrencyException ex)
            //{
            //    var Values = ex.Entries.FirstOrDefault();

            //    Values.Reload();

            //    //Values.OriginalValues.SetValues(Values.GetDatabaseValues());    

            //    Emp2.Salary -= 1000;
            //    context2.SaveChanges();
            //}

            #endregion

            Console.ReadKey();
        }
    }
}
