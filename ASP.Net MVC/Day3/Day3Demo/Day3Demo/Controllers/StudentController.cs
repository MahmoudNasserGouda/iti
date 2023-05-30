using Day3Demo.Models;
using Day3Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3Demo.Controllers
{
    public class StudentController : Controller
    {
        DataModel context = new DataModel();
        // GET: Student
        public ActionResult Index()
        {
            //ViewData["StudentsList"] = context.Students.ToList();
            //return View(context.Students.Include("City").ToList());

            List<StudentViewModel> students = new List<StudentViewModel>();
            foreach (var item in context.Students)
            {
                var studentvm = new StudentViewModel();
                studentvm.ID = item.ID;
                studentvm.FullName = item.FullName;
                studentvm.Graduated = item.Graduated;
                studentvm.GPA = item.GPA;
                studentvm.City = context.Cities.Find(item.CityID).Name;
                students.Add(studentvm);
            }

            return View(students);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}