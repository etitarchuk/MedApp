using System.Web;
using System.Web.Optimization;

namespace MedApp.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Content/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Content/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/Bootstrap/bootstrap.js",
                      "~/Content/Bootstrap/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Bootstrap/bootstrap.css",
                      "~/Content/Styles/site.css",
                      "~/Content/Styles/fonts.css"));

            bundles.Add(new StyleBundle("~/Content/smartmenu").Include(
                      "~/Content/JqMenu/sm-core-css.css",
                      "~/Content/JqMenu/sm-styles.css"));

            bundles.Add(new ScriptBundle("~/bundles/smartmenu").Include(
                      "~/Content/JqMenu/jquery.smartmenus.js"));

            bundles.Add(new StyleBundle("~/Content/jqueryui1").Include(
                      "~/Content/JqueryUI/jquery-ui.min.css",
                      "~/Content/JqueryUI/jquery-ui.structure.min.css",
                      "~/Content/JqueryUI/jquery-ui.theme.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Content/JqueryUI/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/grid").Include(
                      "~/Content/JqGrid/grid.locale-en.js",
                      "~/Content/JqGrid/jquery.jqGrid.min.js"));

            bundles.Add(new StyleBundle("~/Content/grid").Include(
                      "~/Content/JqGrid/ui.jqgrid.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
