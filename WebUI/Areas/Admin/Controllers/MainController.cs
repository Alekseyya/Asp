using DomainModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entities;
using DomainModel.Concrete;
using System.IO;


namespace WebUI.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Admin/Main/
        private IStoreRepository _repository;

        public MainController(IStoreRepository repo)
        {
            _repository = repo;
        }


        EFDbContext context = new EFDbContext();
        public ActionResult Index()
        {
            
            return View(_repository.Products);
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the filename
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }
            // redirect back to the index action to show the form once again
            return View("Index");
        }

        
    

    }
}
