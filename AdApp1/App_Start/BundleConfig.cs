using System.Web;
using System.Web.Optimization;

namespace AdApp1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/corners").Include(
                        "~/Scripts/jquery.curvycorners.source.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/consolidatedbase.css"));
                        //"~/Content/Site.css"));
                        //"~/Content/screen.css",
                        //"~/Content/box.css",
                        //"~/Content/default.ultimate.css",
                        //"~/Content/globals.css",
                        //"~/Content/typography.css",
                        //"~/Content/grid.css",
                        //"~/Content/ui.css",
                        //"~/Content/orbit.css",
                        //"~/Content/reveal.css",
                        //"~/Content/app.css",
                        //"~/Content/mobile.css",
                        //"~/Content/forms.css",
                        //"~/Content/new-box.css",
                        //"~/Content/basic-quickflips.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}