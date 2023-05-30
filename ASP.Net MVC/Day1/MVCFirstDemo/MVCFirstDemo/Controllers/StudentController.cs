using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;

namespace MVCFirstDemo.Controllers
{
    public class StudentController:Controller
    {
        public string Greeting()
        {
            return "Hello to First MVC Project";
        }

        public JsonResult All()
        {
            return Json(ApplicationContext.Students, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStudent(int ID)
        {
            return Json(ApplicationContext.Students.Where(s => s.ID == ID).FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }

        public RedirectToRouteResult DeleteStudent(int ID)
        {
            Student student = ApplicationContext.Students.Where(s => s.ID == ID).FirstOrDefault();
            ApplicationContext.Students.Remove(student);
            return RedirectToAction("All");
        }

        public RedirectToRouteResult AddStudent(Student student)
        {
            ApplicationContext.Students.Add(student);
            //return Json(ApplicationContext.Students, JsonRequestBehavior.AllowGet);
            return RedirectToAction("All");
        }

        public RedirectToRouteResult UpdateStudent(Student student)
        {
            Student updateStudent = ApplicationContext.Students.Where(s => s.ID ==  student.ID).FirstOrDefault();
            ApplicationContext.Students.Remove(updateStudent);

            ApplicationContext.Students.Add(student);

            return RedirectToAction("All");
        }
    }
}