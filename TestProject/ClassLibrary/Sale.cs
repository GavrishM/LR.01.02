using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Sale
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Sale(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Sale() { }
    }
}
