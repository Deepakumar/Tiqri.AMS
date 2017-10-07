using System.Web;
using System.Web.Optimization;

namespace Tiqri.AMS.Web
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
                      "~/Scripts/jquery.dataTables.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/bootstrap-timepicker.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/moment.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularlib").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-ui-router.js",
                      "~/Scripts/angular-resource.js",
                      "~/Scripts/angular-local-storage.js",
                      "~/Scripts/underscore.js",
                      "~/Scripts/require.js",
                      "~/Scripts/angular-datatables.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularapp").Include(
                      "~/Scripts/app/main.js",
                      "~/Scripts/app/HomeCtrl.js",
                      "~/Scripts/app/AccidentCtrl.js",
                      "~/Scripts/app/LoginCtrl.js",
                      "~/Scripts/app/services/authInterceptorService.js",
                      "~/Scripts/app/services/authService.js",
                      "~/Scripts/app/services/accidentData.js",
                      "~/Scripts/app/services/employeeData.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/bootstrap-timepicker.css",
                      "~/Content/bootstrap-timepicker.css",
                      "~/Content/dataTables.bootstrap.css",
                      "~/Content/Site.css"
                      ));

            System.Web.Optimization.BundleTable.EnableOptimizations = false;
        }
    }
}
