using System.Runtime.InteropServices;

namespace ShoppingCart
{
    internal class ShoppingCart
    {
        private List<OrderLine> OrderLine = new();

        public void Show()
        {
            var orderLine = new OrderLine();
            if (OrderLine.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            orderLine.ShowOrderLine(OrderLine);
        }

        public void Add(Product aProduct, int count)
        {
            var existingOrderLine = FindOrderLine(aProduct);
            
            if (existingOrderLine != null)
            {
                existingOrderLine.AddCount(count);
            }
            else
            {
                OrderLine myOrderLine = new OrderLine(aProduct, count);
                OrderLine.Add(myOrderLine);
            }

            Console.WriteLine($"Du kjøpte {count} stk. {aProduct.Name}");
        }

        private OrderLine? FindOrderLine(Product product)
        {
            OrderLine existingOrderLine = null;

            foreach (var orderLine in OrderLine)
            {
                if (orderLine.Product == product)
                {
                    existingOrderLine = orderLine;
                }
            }
            return existingOrderLine;
        }

    }
}
