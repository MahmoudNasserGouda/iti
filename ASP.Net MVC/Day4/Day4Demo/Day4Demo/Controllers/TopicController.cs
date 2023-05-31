using Day4Demo.Models;
using Day4Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4Demo.Controllers
{
    public class TopicController : Controller
    {
        ApplicationContext context = new ApplicationContext();
        // GET: Topic
        public ActionResult Index()
        {
            return View(context.Topics.ToList());
        }

        public ActionResult Create()
        {
            return View(new TopicVM());
        }

        [HttpPost]
        public ActionResult Create(TopicVM topicVM)
        {
            if (ModelState.IsValid)
            {
                Topic topic = new Topic();
                topic.Top_Id = topicVM.Top_Id;
                topic.Top_Name = topicVM.Top_Name;
                context.Topics.Add(topic);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topicVM);
        }
    }
}