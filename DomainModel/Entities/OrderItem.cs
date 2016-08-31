using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool IsClosed { get; set; }
        public string OrderStatusComment { get; set; }
        public DateTime CreationTime { get; set; }
        public int? OrderId { get; set; }
        public string OrderStatus { get; set; }
        public int? ProductId { get; set; }
        public int? ClientId { get; set; }
       
       
        public Product Product { get; set; }
        public Client Client { get; set; }

        public double Total { get { return Quantity * Convert.ToDouble(Product.Price); } }
        
    }
}
