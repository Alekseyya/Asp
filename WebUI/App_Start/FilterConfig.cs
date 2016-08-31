using System.Web;
using System.Web.Mvc;

namespace WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
        //internal static void RegisterGlobalFilters(GlobalFilterCollection globalFilterCollection)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}