using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class City
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        public int? RegionId { get; set; }
        public Region Region { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        
    }
}
