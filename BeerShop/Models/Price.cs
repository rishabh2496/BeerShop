using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeerShop.Models
{
    public class Price
    {
        public int ID { get; set; }
        public decimal Rate { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
