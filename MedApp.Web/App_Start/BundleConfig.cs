using System.Web;
using System.Web.Optimization;

namespace MedApp.Web
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
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/custom").Include(
                      "~/Content/layout.css"));

            bundles.Add(new StyleBundle("~/Content/smartmenu").Include(
                      "~/Content/sm-core-css.css",
                      "~/Content/sm-styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/smartmenuscript").Include(
                      "~/Scripts/jquery.smartmenus.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                      "~/Content/jquery-ui-1.11.2.custom/jquery-ui.min.css",
                      "~/Content/jquery-ui-1.11.2.custom/jquery-ui.structure.min.css",
                      "~/Content/jquery-ui-1.11.2.custom/jquery-ui.theme.min.css",
                      "~/Content/jquery-ui-1.11.2.custom/ui.jqgrid.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryuiscript").Include(
                      "~/Scripts/jquery-ui-1.11.2.custom/jquery-ui.min.js",
                      "~/Scripts/jquery-ui-1.11.2.custom/grid.locale-en.js",
                      "~/Scripts/jquery-ui-1.11.2.custom/jquery.jqGrid.min.js"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
