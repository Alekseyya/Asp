using DomainModel.Abstract;
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
    public class OrderController : Controller
    {
        //
        // GET: /Order/
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddToOrder(int Id, int Quantity)
        {
            Product product=null;
            Client user =null;
            using (EFDbContext db = new EFDbContext())
            {
                product = db.Products.FirstOrDefault(p => p.Id == Id);
                user = db.Clients.SingleOrDefault(u => u.Login == User.Identity.Name);

            }
            if (product != null)
            {
                using (EFDbContext db = new EFDbContext())
                {
                    db.OrderItems.Add(new OrderItem
                    {
                       Description= product.Description,
                       Quantity = Quantity,
                       CreationTime = DateTime.Now,
                       OrderStatus = "Обработка заказа",
                       ProductId = product.Id,
                       ClientId = user.Id
                    });
                    db.SaveChanges();
                }
                
            }

            return RedirectToAction("List"); 
        }

        [HttpPost]
        public RedirectToRouteResult RemoveFromOrder(int Id)
        {
            
            using (EFDbContext db = new EFDbContext())
            {
                OrderItem item = db.OrderItems.Find(Id);
                db.OrderItems.Remove(item);
                db.SaveChanges();

            }
            
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            if (ModelState.IsValid)
            {
                Client user = null;
                

                using (EFDbContext db = new EFDbContext())
                {
                    user = db.Clients.SingleOrDefault(u => u.Login == User.Identity.Name);
                }
                if (user != null)
                {
                   
                    
                        EFDbContext db = new EFDbContext();
                        //IEnumerable<OrderItem> orderitems = from c in db.OrderItems
                        //                                    where c.OrderId == order.Id
                        //                                    select c;
                        IQueryable<OrderItem> orderitems = db.OrderItems.Include("Product")
                            .Where(c => c.ClientId == user.Id).Select(c => c);
                                                    
                        return View(orderitems);
                        db.Dispose();
                    
                }
            }
            return View();
            
        }

    }
}
