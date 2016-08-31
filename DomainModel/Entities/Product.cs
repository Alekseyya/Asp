using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int BrandId { get; set; }
        public string Articul { get; set; }
        public int? ClientId { get; set; }
        public int? CategoryId { get; set; }
        public Brand Brand { get; set; }
        public Client Client { get; set; }
        public Category Category { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
       
    }
}
