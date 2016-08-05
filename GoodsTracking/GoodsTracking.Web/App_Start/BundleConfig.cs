using System.Web.Optimization;

namespace GoodsTracking.Web.App_Start
{
    /// <summary>
    /// Bundle JavaScript and CSS files
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        /// </summary>
        /// <param name="bundles"></param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            // JQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
                //.Include("~/Scripts/jquery.unobtrusive-ajax.min.js")
                //.Include("~/Scripts/jquery.validate.min.js")
                //.Include("~/Scripts/jquery.validate.unobtrusive.min.js")
                );

            // bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.min.js")
                );

            // Layout CSS
            bundles.Add(new StyleBundle("~/content/css")
                .Include("~/Content/bootstrap.min.css")
                .Include("~/Content/chwapi.css")
                );

            bundles.IgnoreList.Clear();

            BundleTable.EnableOptimizations = true;
        }
    }


}