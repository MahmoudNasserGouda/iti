using Day4Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4Demo.BusinessLogic
{
    public static class HTMLExternalHelper
    {
        public static int CountCourses(this HtmlHelper html, string TopicName)
        {
            ApplicationContext context = new ApplicationContext();
            int topicID = context.Topics.Where(t => t.Top_Name == TopicName).FirstOrDefault().Top_Id;
            int count = context.Courses.Where(c => c.Top_Id == topicID).Count();

            TagBuilder tag = new TagBuilder("label");
            tag.SetInnerText(count.ToString());

            //return new MvcHtmlString(tag.ToString());
            return count;
        }
    }
}