using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Areas.Store.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Store/Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Feedback()
        {
            FeedbackViewModel model = new FeedbackViewModel();
           
            return View(model);
        }


    }
}
