﻿namespace ShoppingCart
{
    internal class ShoppingCart
    {
        private List<OrderLine?> _orderLines = new();

        public void Show()
        {
            var totalSumOfOrderLine = 0;

            if (_orderLines.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            Console.WriteLine("\nHandlekurv:");
            

            foreach (var orderLine in _orderLines)
            {
                 int SumOfOrderLine = orderLine.Show();
                 totalSumOfOrderLine += SumOfOrderLine;
            }
            Console.WriteLine($"Totalpris: {totalSumOfOrderLine}");
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
                var myOrderLine = new OrderLine(aProduct, count);
                _orderLines.Add(myOrderLine);
            }
            
            Console.WriteLine($"Du kjøpte {count} stk. {aProduct.Name}");
        }

        private OrderLine? FindOrderLine(Product product)
        {
            OrderLine? existingOrderLine = null;

            foreach (var orderLine in _orderLines)
            {
                if (orderLine?.Product == product)
                {
                    existingOrderLine = orderLine;
                }
            }
            return existingOrderLine;
        }

    }
}
