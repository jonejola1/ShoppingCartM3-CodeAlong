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

        public OrderLine()
        {
            
        }
        public OrderLine(Product aProduct, int aCount)
        {
            Product = aProduct;
            Count = aCount;
        }

        public void AddCount(int aCount)
        {
            Count += aCount;
        }

        public void ShowOrderLine(List<OrderLine> aOrderLine)
        {
            Console.WriteLine("\nHandlekurv:");
            var totalPrice = 0;
            foreach (var order in aOrderLine)
            {
                var count = order.Count;
                var productName = order.Product.Name;
                var price = order.Product.Price;
                var orderLinePrice = price * count;
                Console.WriteLine($"  {count} stk. {productName} for kr {price} = {orderLinePrice}");
                totalPrice += orderLinePrice;
            }

            Console.WriteLine($"Totalpris: {totalPrice}");
        }
    }
}
