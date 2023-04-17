using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class OrderLine
    {

        private string _product;
        private int _count;

        public OrderLine(string aProduct, int aCount)
        {
            _product = aProduct;
            _count = aCount;
        }
    }
}
