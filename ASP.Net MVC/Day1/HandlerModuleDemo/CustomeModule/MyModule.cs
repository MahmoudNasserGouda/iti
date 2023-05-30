using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CustomeModule
{
    public class MyModule : IHttpModule
    {
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            //url rewriting
            context.BeginRequest += Context_BeginRequest;
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication context = sender as HttpApplication;
            if (context.Request.RawUrl.Contains(".minia"))
            {
                context.Response.Redirect(context.Request.RawUrl.Replace(".minia", ".iti"));
            }
        }
    }
}
