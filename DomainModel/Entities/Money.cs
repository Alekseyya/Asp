using DomainModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Entities
{
    public class Money
    {
        public decimal ValueBase { get; set; }
        public int Id { get; set; }
        public Currency UserCurrency { get; set; }
        public Rate Rates { get; set; }
        public Money(decimal val, Currency userCurrency, Rate rates)
        {
            ValueBase = val;
            UserCurrency = userCurrency;
            Rates = rates;
        }
        public static Money Zero
        {
            get { return new Money(0, Currency.RUR, null); }
        }
    }
}
