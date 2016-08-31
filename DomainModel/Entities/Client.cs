using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Client
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public IEnumerable<Product> Products { get; set; }
        


        
        
    }
}
