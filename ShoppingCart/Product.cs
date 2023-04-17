using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        private string _name;
        private int _price;

        public Product(string aName, int aPrice)
        {
            _name = aName;
            _price = aPrice;
        }
    }
}
