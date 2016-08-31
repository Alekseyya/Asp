using System.Web.Mvc;

namespace WebUI.Areas.Store
{
    public class StoreAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Store";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //context.MapRoute(
            //    "Store_default",
            //    "Store/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);
            //context.MapRoute(null, "Store/Product/List", new { controller = "Product", action = "List"}, new[] { "WebUI.Areas.Store.Controllers" });
            //context.MapRoute(null, "", new { controller = "Product", action = "List" }, new [] { "WebUI.Areas.Store.Controllers" });
            //context.MapRoute(null, "Store/Cart", new { controller = "Cart", action = "Index" }, null, new[] { "WebUI.Areas.Store.Controllers" });
            //context.MapRoute(null, "", new { controller = "Product", action = "List" }, new[] { "WebUI.Areas.Store.Controllers" });

            //context.MapRoute(null, "", new { controller = "Product", action = "List", category = (string)null, page = 1 }, new[] { "WebUI.Areas.Store.Controllers" });
            //context.MapRoute(null, "Page{page}", new { controller = "Product", action = "List", category = (string)null }, new { page = @"\d+" }, new[] { "WebUI.Areas.Store.Controllers" } );
            //context.MapRoute(null, "{category}", new { controller = "Product", action = "List", page = 1 }, new[] { "WebUI.Areas.Store.Controllers" });
            //context.MapRoute(null, "{category}/Page{page}", new { controller = "Product", action = "List" }, new { page = @"\d+" }, new[] { "WebUI.Areas.Store.Controllers" });
            context.MapRoute(null, "Store/{controller}/{action}", new[] { "WebUI.Areas.Store.Controllers" });
            
        }
    }
}
