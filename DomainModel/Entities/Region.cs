using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Region
    {
        public Region()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
    
        public virtual Country Countries { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
