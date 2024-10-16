using System.Web.Optimization;

namespace BaiTapTuan01
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // js home
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/js/jquery-3.3.1.min.js",
                "~/Scripts/js/theme-change.js",
                "~/Scripts/js/jquery.waypoints.min.js",
                "~/Scripts/js/jquery.countup.js",
                "~/Scripts/js/owl.carousel.js",
                "~/Scripts/js/jquery.magnific-popup.min.js",
                "~/Scripts/js/bootstrap.min.js",
                "~/Scripts/js/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
