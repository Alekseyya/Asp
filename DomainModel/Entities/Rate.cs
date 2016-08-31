using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public decimal RateEurUsd { get; set; }
        public decimal RateUsdRur { get; set; }
    }
}
