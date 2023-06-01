using WebApplication1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.BusinessLogic;
using WebApplication1.Models;

namespace Day4Demo.Controllers
{
    public class CourseController : Controller
    {
        ApplicationContext context = new ApplicationContext();

        // GET: Course
        //[ChildActionOnly]
        public ActionResult Index()
        {
            List<CourseVM> CoursesVM = ConvertionToVM.ConvertToCourseVM(context.Courses.ToList());
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
                    return Json(new { success = true });
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

        [HttpGet]
        public ActionResult Delete (int? id)
        {
            Course c = context.Courses.Where(x => x.Crs_Id == id).FirstOrDefault();
            context.Courses.Remove(c);
            context.SaveChanges();
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Details (int? id)
        {
            CourseVM c = ConvertionToVM.ConvertToCourseVM(context.Courses.Where(x => x.Crs_Id == id).ToList()).FirstOrDefault();
            return View(c);
        }

        public ActionResult Edit(int? id)
        {
            Course c = context.Courses.Where(x => x.Crs_Id == id).FirstOrDefault();
            ViewBag.Instructors = context.Instructors.ToList();
            ViewBag.Topics = context.Topics.ToList();
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                Course c = context.Courses.Where(x => x.Crs_Id == course.Crs_Id).FirstOrDefault();
                c.Crs_Duration = course.Crs_Duration;
                c.Crs_Name = course.Crs_Name;
                c.Top_Id = course.Top_Id;
                c.Ins_Id = course.Ins_Id;
                try
                {
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception e)
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