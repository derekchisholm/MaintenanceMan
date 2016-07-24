using System.Web.Optimization;

namespace MaintenanceMan.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            //VENDOR RESOURCES

            //~/Bundles/App/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/App/vendor/css")
                    //.Include("~/Content/toastr.min.css", new CssRewriteUrlTransform())
                    //.Include("~/Scripts/sweetalert/sweet-alert.css", new CssRewriteUrlTransform())
                    //.Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    //.Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/global/plugins/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/global/plugins/simple-line-icons/simple-line-icons.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/global/plugins/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css", new CssRewriteUrlTransform())
                );

            //~/Bundles/App/vendor/js
            bundles.Add(
                new ScriptBundle("~/Bundles/App/vendor/js")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/json2.min.js",

                        "~/Scripts/modernizr-2.8.3.js",
                        
                        "~/Scripts/jquery-2.2.0.min.js",
                        "~/Scripts/jquery-ui-1.11.4.min.js",

                        "~/Scripts/bootstrap.min.js",

                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",
                        "~/Scripts/others/spinjs/spin.js",
                        "~/Scripts/others/spinjs/jquery.spin.js",

                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-animate.min.js",
                        "~/Scripts/angular-sanitize.min.js",
                        "~/Scripts/angular-ui-router.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap.min.js",
                        "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js",
                        "~/Scripts/angular-ui/ui-utils.min.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",
                        "~/Abp/Framework/scripts/libs/angularjs/abp.ng.js",

                        "~/Scripts/jquery.signalR-2.2.0.min.js"
                    )
                );

            //APPLICATION RESOURCES

            //~/Bundles/App/Main/css
            bundles.Add(
                new StyleBundle("~/Bundles/App/Main/css")
                    .Include("~/Content/themes/metronic/assets/global/css/components.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/global/css/plugins.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/layouts/layout2/css/layout.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/layouts/layout2/css/themes/dark.css", new CssRewriteUrlTransform())
                    .Include("~/Content/themes/metronic/assets/layouts/layout2/css/custom.min.css", new CssRewriteUrlTransform())
                    .IncludeDirectory("~/App/Main", "*.css", true)
                );

            //~/Bundles/App/Main/js
            bundles.Add(
                new ScriptBundle("~/Bundles/App/Main/js")
                    .Include("~/Content/themes/metronic/assets/global/scripts/app.js")
                    .Include("~/Content/themes/metronic/assets/layouts/layout2/scripts/layout.js")
                    .IncludeDirectory("~/Common/Scripts", "*.js", true)
                    .IncludeDirectory("~/App/Main", "*.js", true)
                );
        }
    }
}