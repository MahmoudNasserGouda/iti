using Day4Demo.BusinessLogic;
using Day4Demo.Models;
using Day4Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4Demo.Controllers
{
    public class CourseController : Controller
    {
        ApplicationContext context = new ApplicationContext();

        // GET: Course
        public ActionResult Index()
        {
            List<CourseVM> CoursesVM = ConvertionToVM.ConvertToCourseVM(context.Courses.ToList());
            return View(CoursesVM);
        }

        public ActionResult IndexByTopic()
        {
            List<CourseVM> CoursesVM = ConvertionToVM.ConvertToCourseVM(context.Courses.ToList());
            ViewData["Topics"] = context.Topics.ToList();
            
            return View(CoursesVM);
        }

        public ActionResult Create()
        {
            ViewBag.Instructors = context.Instructors.ToList();
            ViewBag.Topics = context.Topics.ToList();
            return View(new Course());
        }

        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                context.Courses.Add(course);
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch(Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.InnerException.InnerException.Message);
                    ViewBag.Instructors = context.Instructors.ToList();
                    ViewBag.Topics = context.Topics.ToList();
                    return View(course);
                }
            }
            ViewBag.Instructors = context.Instructors.ToList();
            ViewBag.Topics = context.Topics.ToList();
            return View(course);
        }
    }
}