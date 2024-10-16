using System.Web.Optimization;

namespace BaiTapTuan01
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // css Profile
            bundles.Add(new StyleBundle("~/bundles/ProfileCSS").Include(
                "~/Content/ProfileContent/css/bootstrap.min.css",
                "~/Content/ProfileContent/css/bootstrap-icons.css",
                "~/Content/ProfileContent/css/apexcharts.css",
                "~/Content/ProfileContent/css/tooplate-mini-finance.css"));

            // js Profile
            bundles.Add(new ScriptBundle("~/bundles/ProfileJS").Include(
                "~/Scripts/ProfileJS/jquery.min.js",
                //"~/Scripts/ProfileJS/bootstrap.bundle.min.js",
                "~/Scripts/ProfileJS/apexcharts.min.js",
                "~/Scripts/ProfileJS/custom.min.js",
                "~/Scripts/ProfileJS/script.min.js"));

            // js Home
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
