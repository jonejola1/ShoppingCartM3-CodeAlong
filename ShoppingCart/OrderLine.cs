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

        public void AddCount(int aCount)
        {
            Count += aCount;
        }

        
        public void Show()
        {
            Console.WriteLine("\nHandlekurv:");
            var totalPrice = 0;
            var count = this.Count;
            var productName = this.Product.Name;
            var price = this.Product.Price;
            var orderLinePrice = price * count;
            Console.WriteLine($"  {count} stk. {productName} for kr {price} = {orderLinePrice}");
            totalPrice += orderLinePrice;

            Console.WriteLine($"Totalpris: {totalPrice}");
        }
    }
}
