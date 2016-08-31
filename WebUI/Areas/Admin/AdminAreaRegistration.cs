using System.Web.Mvc;

namespace WebUI.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //context.MapRoute(
            //    "Admin_default",
            //    "Admin/{controller}/{action}/{id}",
            //    new { action = "Index", id = UrlParameter.Optional }
            //);

            //context.MapRoute(null, "", new { controller = "Main", action = "Index"}, new[] { "WebUI.Areas.Admin.Controllers" }); 
            //context.MapRoute(null, "Admin/{controller}/{action}", new[] { "WebUI.Areas.Admin.Controllers" });
            
        }
    }
}
