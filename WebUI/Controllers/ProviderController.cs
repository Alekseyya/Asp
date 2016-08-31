using DomainModel.Concrete;
using DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ProviderController : Controller
    {
        //
        // GET: /Provider/

        public ActionResult Index()
        {
            return View();
        }
        public FileResult GetFile()
        {
            // Путь к файлу
            string file_path = Server.MapPath("~/Content/Files/ExampleXml.xml");
            // Тип файла - content-type
            string file_type = "application/xml";
            // Имя файла - необязательно
            string file_name = "ExampleXml.xml";
            return File(file_path, file_type, Server.UrlEncode(file_name));
        }

        //public PartialViewResult Success(string submit)
        //{
            
        //        IEnumerable<Price> price = null;
        //        using (EFDbContext db = new EFDbContext())
        //        {
        //            var user = db.Clients.SingleOrDefault(c => c.Login == User.Identity.Name);
        //            price = db.Prices.Where(c => c.ClientId == user.Id).Select(c => c);

        //        }

        //        ViewBag.Result = price;
            
           
        //    return PartialView();
        //}

        [HttpPost]
        public ActionResult UploadXML(HttpPostedFileBase file)
        {
            
            if (ModelState.IsValid)
            {
                Client user = null;
                if (file.ContentType.Equals("application/xml") || file.ContentType.Equals("text/xml"))
                {
                    try
                    {
                        var xmlPath = Server.MapPath("~/Content/Files" + file.FileName);
                        file.SaveAs(xmlPath);
                        XDocument xDoc = XDocument.Load(xmlPath);
                        PriceImport price1 = new PriceImport();

                        List<PriceImport> price = (from c in xDoc.Descendants("Items")
                                                   select new PriceImport()
                                                   {
                                                       Brand = c.Element("Brand").Value,
                                                       Articul = c.Element("Articul").Value,
                                                       Description = c.Element("Description").Value,
                                                       BasePrice = Convert.ToDecimal(c.Element("BasePrice").Value),
                                                       Quantity = Convert.ToInt32(c.Element("Quantity").Value)
                                                   }).ToList();
                        //дописать проверку на логин
                        using (EFDbContext db = new EFDbContext())
                        {
                            user = db.Clients.SingleOrDefault(u => u.Login == User.Identity.Name);
                        }
                        if (user != null)
                        {
                            using (EFDbContext db = new EFDbContext())
                            {
                                foreach (var i in price)
                                {
                                    db.Prices.Add(new Price
                                    {
                                        Brand = i.Brand,
                                        Articul = i.Articul,
                                        Description = i.Description,
                                        BasePrice = i.BasePrice,
                                        Quantity = i.Quantity,
                                        ClientId = user.Id

                                    });
                                }
                                db.SaveChanges();
                                ViewBag.Result = price;
                            }
                        }
                        

                        return PartialView("Success");
                    }
                    catch
                    {
                        ViewBag.Error = "Не импортировался файл";
                        return View("Index");
                    }

                }
                else
                {
                    ViewBag.Error = "Не импортировался файл";
                    return View("Index");
                }
            }
            return View("Index");
            
        }


    }
}


//var list = from c in xDoc.Root.Elements("item") select c;
////var list1 = from c in XElement.Load(System.Web.Hosting.HostingEnvironment.MapPath(xmlPath)).Elements("item")
////           select c;

//foreach(var item in list)
//{
//    price.Add(new PriceImport() { Brand = item.Element("Brand").Value, Articul = item.Element("Articul").Value,
//                                  Description = item.Element("Description").Value,
//                                  BasePrice = Convert.ToDecimal(item.Element("BasePrice").Value),
//                                  Quantity = Convert.ToInt32(item.Element("Quantity").Value)
//    });

//}

//Это работает

//XElement generalElement = xDoc
//.Element("Products")
//.Element("Items");

//price1.Brand = generalElement.Element("Brand").Value;

//var t = price1.Brand;