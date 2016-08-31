using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUI.Areas.Store.Models
{
    public class FeedbackViewModel
    {
        public string Contacter { get; set; }
        public string Message { get; set; }
                      
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}