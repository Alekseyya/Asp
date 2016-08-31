using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Articul
    {
        [Key]
        [ForeignKey("OrderItem")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public OrderItem OrderItem { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
