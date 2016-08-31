using DomainModel.Concrete;
using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public int PageSize = 20;
        public ActionResult Index(int page = 1)
        {
            EFDbContext db = new EFDbContext();
            ProductsListViewModel model = new ProductsListViewModel
                {
                    Products = db.Products
                    .Include("Category")
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize).AsEnumerable(),
                    PagingInfo = new PagingInfo
                    {
                        CurrentPage = page,
                        ItemsPerPage = PageSize,
                        TotalItems = db.Products.Count()
                    }
                };

            return View(model);
        }
        public ActionResult List(int page = 1)
        {

            EFDbContext db = new EFDbContext();
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = db.Products
                .Include("Brand")
                .OrderBy(p => p.Id)
                .Skip((page - 1) * PageSize)
                .Take(PageSize).AsEnumerable(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = db.Products.Count()
                }
            };
            

            return View(model);
        }

        public ActionResult Search(string product, int page = 1)
        {
            EFDbContext db = new EFDbContext();
            
                var products = from s in db.Products
                               select s;


                if (!String.IsNullOrEmpty(product))
                {
                   

                    ProductsListViewModel model = new ProductsListViewModel
                    {
                        Products = db.Products
                        .Include("Brand")
                        .Where(c => c.Articul.Contains(product))
                        .OrderBy(p => p.Id)
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize).AsEnumerable(),
                        PagingInfo = new PagingInfo
                        {
                            CurrentPage = page,
                            ItemsPerPage = PageSize,
                            TotalItems = db.Products.Count()
                        }
                    };
                    return View("List", model);
                }
                return RedirectToAction("List");
            
        }

    }

}

