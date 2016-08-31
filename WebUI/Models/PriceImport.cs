using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WebUI.Models
{
    [Serializable]
    [XmlRoot("item")]
    public class PriceImport
    {
        [XmlElement("Brand")]
        public string Brand { get; set; }

        [XmlElement("Articul")]
        public string Articul { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("BasePrice")]
        public decimal BasePrice { get; set; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }
    }
}