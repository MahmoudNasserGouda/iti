using Day2Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2Demo.BusinessLogic;

namespace Day2Demo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //to pass data from action to its view
            //1. ViewData: Dictionary ViewData[Key]=value;
            //2. ViewBag: Dynamic ViewBag.Key = value;
            //3. Public Proberty Model in View 
            ViewData["StudentsList"] = ApplicationContext.Students;
            ViewData["Title"] = "All Students";
            return View(ApplicationContext.Students.ToArray());
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Student student)
        {
            if (StudentValidation.StudentIsValid(student))
            {
                ApplicationContext.Students.Add(student);
                return RedirectToAction("Index");
            }
            else
            {
                //return View();
                throw new HttpException("Student ID Already Exists");
            }
            //return View("Index");
        }

        public ActionResult Edit(int? id)
        {
            if(id != null)
            {
                var student = ApplicationContext.Students.Where(s => s.ID == id).FirstOrDefault();
                ViewBag.Student = student;
                return View();
            }

            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            Student std = ApplicationContext.Students.Where(s => s.ID == student.ID).FirstOrDefault();
            if(std != null)
            {
                std.Name = student.Name;
                std.GPA = student.GPA;
                TempData["Updated"] = std.Name;
                Session["Updated"] = std.Name;
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
    }
}