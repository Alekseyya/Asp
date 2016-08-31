using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebUI.Infrastructure;

namespace WebUI
{
    // Примечание: Инструкции по включению классического режима IIS6 или IIS7 
    // см. по ссылке http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        //public static void RegisterRoutes(RouteCollection routes)
        //{
        //    routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

        //    routes.MapRoute(
        //        name: "Default",
        //        url: "{controller}/{action}",
        //        defaults: new { controller = "Home", action = "Index"},
        //        namespaces: new[] { "WebUI.Areas.Store.Controllers" }
        //    );
        //    //routes.MapRoute("Store", "{controller}/{action}", new { controller = "Product", action = "List" }, new[] { "WebUI.Areas.Store.Controllers" });
        //    //routes.MapRoute("Admin", "Admin/{controller}/{action}", new {controller = "Main", action = "Index" }, new[] { "WebUI.Areas.Admin.Controllers" });
        //}
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            

        }
    }
}