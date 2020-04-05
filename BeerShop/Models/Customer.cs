using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerShop.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public int BeerID { get; set; }
        public int PriceID { get; set; }
        public Beer Beer { get; set; }
        public Price Price { get; set; }
    }
}
