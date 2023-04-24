namespace ShoppingCart
{
    internal class ShoppingCart
    {
        private List<OrderLine> OrderLine = new List<OrderLine>();

        public void Add(Product aProduct, int count, Product[] aProducts)
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

            Console.WriteLine($"Du kjøpte {count} stk. {aProduct}");
        }

        public void Show()
        {
            if (OrderLine.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }
            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;
            for (int i = 0; i < OrderLine.Count; i++)
            {
                var count = OrderLine[i].Count;
                var productName = OrderLine[i].Product.Name;
                var price = OrderLine[i].Product.Price;
                var orderLinePrice = price * count;
                Console.WriteLine($"  {count} stk. {productName} a kr {price} = {orderLinePrice}");
                totalPrice += orderLinePrice;
            }

            Console.WriteLine($"Totalpris: {totalPrice}");
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
