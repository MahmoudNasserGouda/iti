using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CustomeHandler
{
    public class MyHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            //select html file and display it
            context.Response.Write("Welcome to our web application");
        }
    }
}
