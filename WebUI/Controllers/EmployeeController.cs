using DomainModel.Abstract;
using DomainModel.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomainModel.Entities;

namespace WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        //private IStoreRepository _repository;

        //public EmployeeController(IStoreRepository repo)
        //{
        //    _repository = repo;
        //}

        public ActionResult EmployeesList()
        {
            EFDbContext db = new EFDbContext();
           
            IEnumerable<Employee> emloyees = db.Employees.Select(c => c);

            return View(emloyees);
        }

    }
}
