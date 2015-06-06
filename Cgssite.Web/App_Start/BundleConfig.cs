using System.Web;
using System.Web.Optimization;

namespace CgsSite.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/jquery.easing.min.js",
                      "~/Scripts/Site.js"));
            bundles.Add(new ScriptBundle("~/Content/tinymce").Include(
                      "~/Scripts/tinymce/tinymce.min.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                //"~/Content/site.css",
                      "~/Content/font-awesome.min.css"));
            bundles.Add(new StyleBundle("~/Content/site").Include(
                                      "~/Content/Site.css",
                                      "~/Content/Validate.css"));
        }
    }
}
