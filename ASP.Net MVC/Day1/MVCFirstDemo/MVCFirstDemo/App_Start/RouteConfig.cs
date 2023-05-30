using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCFirstDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Domain/Student

            routes.MapRoute(
                name: "Custom1",
                url: "Students",
                defaults: new { controller = "Student", action = "All" }
            );

            routes.MapRoute(
                name: "Custom2",
                url: "getStudent/{id}",
                defaults: new { controller = "Student", action = "GetStudent", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Custom3",
                url: "deleteStudent/{id}",
                defaults: new { controller = "Student", action = "DeleteStudent", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Custom4",
                url: "addStudent",
                defaults: new { controller = "Student", action = "AddStudent"}
            );

            routes.MapRoute(
                name: "Custom5",
                url: "updateStudent",
                defaults: new { Controller = "Student", action = "UpdateStudent"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Greeting", id = UrlParameter.Optional }
            );
        }
    }
}
