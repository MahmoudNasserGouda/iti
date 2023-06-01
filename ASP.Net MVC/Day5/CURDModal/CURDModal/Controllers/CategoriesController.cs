using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CURDModal.Models;

namespace CURDModal.Controllers
{
    public class CategoriesController : Controller
    {
        private CompanyEntities db = new CompanyEntities();

        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Create()
        {
            return View(new Category());
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
                return Json(new { success = true}, JsonRequestBehavior.AllowGet);
            }

            string message = "";
            foreach (var item in ModelState.Values)
            {
                if (item.Errors.Count>0)
                {
                    message += item.Errors[0].ErrorMessage;
                }
            }
            return Json(new { success = false, Message = message }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);
            }
            string message = "";
            foreach (var item in ModelState.Values)
            {
                if (item.Errors.Count > 0)
                {
                    message += item.Errors[0].ErrorMessage;
                }
            }
            return Json(new { success = false, Message = message }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
