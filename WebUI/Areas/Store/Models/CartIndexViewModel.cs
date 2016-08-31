using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomainModel.Entities;

namespace WebUI.Areas.Store.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}