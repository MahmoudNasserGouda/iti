using Day5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day5Demo.Controllers
{
    public class TopicController : Controller
    {
        ApplicationContext context = new ApplicationContext();
        // GET: Topic
        //[ChildActionOnly]
        public ActionResult Index()
        {
            return View(context.Topics.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                context.Topics.Add(topic);
                try
                {
                    context.SaveChanges();
                    //return RedirectToAction("Create");
                    return Json(new { success = true});
                }
                catch(Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.InnerException.InnerException.Message);
                    return View(topic);
                }
            }
            return View(topic);
        }

        //stop calling this action from normal request (as Link)
        //allow only child request (as parial view)
        //[ChildActionOnly]
        public ActionResult GetLastTopicID()
        {
            List<int> sid = context.Topics.Select(t => t.Top_Id).ToList<int>();
            int id = sid.Max();
            return PartialView(id);
        }

        public ActionResult GetIDJSON()
        {
            List<int> sid = context.Topics.Select(t => t.Top_Id).ToList<int>();
            int id = sid.Max();
            return Json(new { LastID = id }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var tobeDeleted = context.Topics.Find(id);
            context.Topics.Remove(tobeDeleted);
            context.SaveChanges();
            return Json(new { success = true }, JsonRequestBehavior.AllowGet);
        }
    }
}