using Day2Demo.BusinessLogic;
using Day2Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2Demo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewData["EmployeesList"] = ApplicationContext.Employees;
            ViewData["Title"] = "All Employees";
            return View(ApplicationContext.Employees.ToArray());
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Employee employee)
        {
            if (EmployeeValidation.EmployeeIsValid(employee))
            {
                ApplicationContext.Employees.Add(employee);

                HttpCookie httpCookie = new HttpCookie(employee.Name, DateTime.UtcNow.ToString());
                httpCookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(httpCookie);

                return RedirectToAction("Index");
            }
            else
            {
                throw new HttpException("Employee ID Already Exists");
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var emp = ApplicationContext.Employees.Where(s => s.ID == id).FirstOrDefault();
            ApplicationContext.Employees.Remove(emp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                var emp = ApplicationContext.Employees.Where(s => s.ID == id).FirstOrDefault();
                ViewBag.Employee = emp;
                return View();
            }

            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            Employee emp = ApplicationContext.Employees.Where(s => s.ID == employee.ID).FirstOrDefault();
            if (emp != null)
            {
                emp.Name = employee.Name;
                emp.Salary = employee.Salary;
                TempData["Updated"] = emp.Name;
                Session["Updated"] = emp.Name;
                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }
    }
}