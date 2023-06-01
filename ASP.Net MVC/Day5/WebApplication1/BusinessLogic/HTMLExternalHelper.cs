using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.BusinessLogic
{
    public static class HTMLExternalHelper
    {
        public static MvcHtmlString CourseTitle(this HtmlHelper html, string CourseName)
        {

            TagBuilder tag = new TagBuilder("h4");
            tag.SetInnerText("Course: " + CourseName);

            return new MvcHtmlString(tag.ToString());
        }

    }
}