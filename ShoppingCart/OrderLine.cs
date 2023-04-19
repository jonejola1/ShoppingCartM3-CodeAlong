using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class OrderLine
    {

        public Product Product { get; private set; }
        public int Count { get; private set; }

        public OrderLine(Product aProduct, int aCount)
        {
            Product = aProduct;
            Count = aCount;
        }

        public void addCount(int aCount)
        {
            Count += aCount;
        }
    }
}
