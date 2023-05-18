using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITIEntities context = new ITIEntities();

            Course course = new Course()
            {
                Crs_Id = 1300,
                Crs_Name = "Math"
            };
            context.Courses.Add(course);
            context.SaveChanges();



            var course1 = context.Courses.FirstOrDefault();
            course1.Crs_Name = "HTML5";
            context.SaveChanges();



            var department = context.Departments.Where(x => x.Dept_Id == 70).FirstOrDefault();
            context.Departments.Remove(department);
            context.SaveChanges();



            foreach (var item in context.GetCoursesNames())
            {
                Console.WriteLine(item);
            }

            ITIEntities context2 = new ITIEntities();

            Course c1 = context.Courses.FirstOrDefault();
            Course c2 = context2.Courses.FirstOrDefault();

            c1.Crs_Duration -= 10;
            c2.Crs_Duration -= 10;

            context.SaveChanges();

            var saved = false;
            while (!saved)
            {
                try
                {
                    context2.SaveChanges();
                    saved = true;
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    var Values = ex.Entries.FirstOrDefault();

                    Values.Reload();
   
                    c2.Crs_Duration -= 10;
                    context2.SaveChanges();
                }
            }
            
            Console.ReadKey();
        }
    }
}
