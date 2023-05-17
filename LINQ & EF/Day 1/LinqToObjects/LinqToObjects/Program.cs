using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yiled & Filter Fun
            ////IEnumerable<int> Result = Testyield();


            ////foreach (var item in Result)
            ////{
            ////    Console.WriteLine(item);
            ////}


            //List<int> L = new List<int> { 1, 2, 3, 4, 5, 6,7 };
            //IEnumerable<int> Result = new List<int>();
            ////Result = L.Filter(e => e > 4);
            //Result = L.Where(e => e > 4);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //L.Add(8);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region select & anonymous
            //var Query = SampleData.Departments.Select(d => d);//deferred
            //var Query2 = SampleData.Departments.Select(d => d).ToList(); //eager

            //var Query = SampleData.Departments.Select(d => new {d.Name, d.Address});

            //foreach (var item in Query)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region PipeLine

            //var Query = SampleData.Departments.Select(d => d).Where(d=>d.Name.Contains("a"));
            //var Query = SampleData.Departments.Select(d => d.Address).Where(d=>d.Name.Contains("a"));

            #endregion

            #region Query Experssion

            //var Query =( from d in SampleData.Departments
            //            where d.Name.Contains("a")
            //            select d).ToList();



            #endregion

            #region Order by

            //var Query = from d in SampleData.Departments
            //            orderby d.Name descending , d.Address ascending 
            //            select d;

            //var Query = SampleData.Departments.Select(d => d).OrderBy(d=>d.Name).ThenByDescending(d=>d.Address);


            #endregion

            #region Take,TakeWhile, Skip, First , FirstOrDefault


            //var Query = (from d in SampleData.Departments
            //             select d).Skip(2);//Take(2);

            //var Q = (from c in SampleData.Courses
            //         where c.Hours>18
            //         select c).SkipWhile(c => c.Hours > 18);//.TakeWhile(c=>c.Hours >18);

            //var Q = (from c in SampleData.Courses
            //         where c.Hours > 80
            //         select c).Take(1);

            ////var Q = (from c in SampleData.Courses
            ////         where c.Hours > 80
            ////         select c).FirstOrDefault();


            //Console.WriteLine(Q);

            //var Q2 = (from c in SampleData.Courses
            //         where c.Hours > 18
            //         select c);

            //foreach (var item in Q2)
            //{
            //    Console.WriteLine(item.Name);
            //}




            #endregion

            #region Aggeregate Functions

            //var Query = (from c in SampleData.Courses
            //             select c.Hours).Max();

            //var Query = (from c in SampleData.Courses
            //             select c).Max(); //Exception, must implement IComparable

            //var Query = (from c in SampleData.Courses
            //             select c).Max(c=>c.Hours);



            //Console.WriteLine(Query);

            #endregion

            #region Joins

            //var Q = from c in SampleData.Courses
            //        from d in SampleData.Departments
            //        where c.Department == d
            //        select new {c.Name,DeptName= c.Department.Name};

            //var Q = from c in SampleData.Courses
            //        join d in SampleData.Departments
            //        on c.Department equals d
            //        select new { c.Name, DeptName = c.Department.Name };

            //var Q = from c in SampleData.Courses
            //        select new { c.Name, DeptName= c.Department.Name };

            //foreach (var item in Q)
            //{
            //    Console.WriteLine(item.Name +"..."+item.DeptName);
            //    //Console.WriteLine( item.DeptName);
            //}

            #endregion

            #region SubQuery


            //    var Q = from d in SampleData.Departments
            //            select new
            //            {
            //                d.Name,
            //                Courses = from c in SampleData.Courses
            //                          where c.Department == d
            //                          select c.Name
            //};
            //    foreach (var item in Q)
            //    {
            //        Console.WriteLine(item.Name);
            //        foreach (var c in item.Courses)
            //        {
            //            Console.WriteLine(c);
            //        }
            //    }


            #endregion


            #region Casting 

            //=== 1 === not the best
            //var Query = from Course c in SampleData.GetCourses()
            //            select c;

            //=== 2 === not the best
            //var Query = from c in SampleData.GetCourses().Cast<Course>()    
            //            select c;

            //=== 3 === the best
            //var Query = from c in SampleData.GetCourses().OfType<Course>()
            //            select c;



            #endregion

            Console.ReadKey();
        }

        #region Using yield 
        ////Egar Execution === sub-routin
        //public static IEnumerable<int> Test()
        //{
        //    return new List<int> { 1, 2, 3, 4, 6 };
        //    Console.WriteLine("Ay7aga");
        //}


        ////Deffered Excution ==> co-routine
        //public static IEnumerable<int> Testyield()
        //{
        //    Console.WriteLine("First");
        //    yield return 1;
        //    Console.WriteLine("Second");
        //    yield return 2;
        //    Console.WriteLine("Third");
        //    yield  return 3;

        //} 
        #endregion
    }
}
