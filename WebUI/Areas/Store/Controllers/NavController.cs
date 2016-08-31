using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Abstract;

namespace WebUI.Areas.Store.Controllers
{
    public class NavController : Controller
    {
        private IStoreRepository repository;
        public NavController(IStoreRepository repo)
        {
            repository = repo;
        }
        //public PartialViewResult Menu()
        //{
        //    IEnumerable<string> categories = repository.Products
        //    .Select(x => x.Category)
        //    .Distinct()
        //    .OrderBy(x => x);
        //    return PartialView(categories);
        //}
        public PartialViewResult Menu()
        {
            
            return PartialView();
        }

    }
}
