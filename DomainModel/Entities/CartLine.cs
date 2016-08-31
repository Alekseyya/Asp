using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    [Serializable]
    public class CartLine
    {
        public int Id { get; set; }
        //Количество
        public int Quantity { get; set; }
        public string Comment { get; set; }
        //public int CartId { get; set; }
        public int ItemId { get; set; }
        public string Articul { get; set; }
        public string BrandName { get; set; }

        public Product Product { get; set; }

        [NotMapped]
        public Money Price { get; set; }

        //[NotMapped]
        //public Money TotalPrice
        //{
        //    get
        //    {
        //        return Price * TotalPrice.;
        //    }
        //}
    }
}
