using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/Style").Include(
                "~/Content/bootstrap.css"//,
                                         //"~/Content/Site.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/BootstrapScript").Include(
                "~/Scripts/jquery-3.4.1.js",
                "~/Scripts/bootstrap.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/ValidationScript").Include(
               "~/Scripts/jquery.validate.js",
               "~/Scripts/jquery.validate.unobtrusive.js"
               ));
        }
    }
}
