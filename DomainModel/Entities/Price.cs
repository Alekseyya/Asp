using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Price
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Articul { get; set; }
        public string Description { get; set; }
        public decimal BasePrice { get; set; }
        public int Quantity { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
