using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entities;
using DomainModel.Concrete;
using System.Web.Security;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Client user = null;
                using(EFDbContext db = new EFDbContext())
                {
                    user = db.Clients.FirstOrDefault(u => u.Login == model.Login);
                }
                if(user == null)
                {
                    using (EFDbContext db = new EFDbContext())
                    {
                        db.Clients.Add(new Client{Name = model.Name, LastName = model.LastName, Login = model.Login,
                        Pass = model.Password, Email = model.Email, Adress= model.Adress});
                        db.SaveChanges();
                        user = db.Clients.Where(u => u.Login == model.Login && u.Pass == model.Password).FirstOrDefault();
                    }
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Login, true);
                        return RedirectToAction("Index", "Account");
                        
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
                   
                
                ModelState.Clear();
                ViewBag.Message = model.Name + " " + model.LastName + " Вы прошли регистрацию.";

            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            Client user = null;
            using(EFDbContext db = new EFDbContext())
            {
                user = db.Clients.FirstOrDefault(u => u.Login == model.Login && u.Pass == model.Password);
                if(user !=null)
                {
                    
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Product");
        }
        public ActionResult LoggedIn()
        {
            if(Session["Id"] !=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
    }
}
