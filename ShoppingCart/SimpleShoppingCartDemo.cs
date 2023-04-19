namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            //var productNames = new[] { "A", "B", "C" };
            //var productPrices = new[] { 40, 70, 30 };
            var A = new Product("A", 40);
            var B = new Product("B", 40);
            var C = new Product("C", 40);

            var products = new Product[] {A, B, C};

            var myShoppingCart = new List<OrderLine>();
            

            //var myShoppingCartP = new List<Product>();
            //var myShoppingCartCounts = new List<int>();
            ShowCart(products, myShoppingCart);
            Buy(A, 1, myShoppingCart);
            ShowCart(products, myShoppingCart);
            Buy(B, 3, myShoppingCart);
            ShowCart(products, myShoppingCart);
            Buy(A, 4, myShoppingCart);
            ShowCart(products, myShoppingCart);
        }

        private static void Buy(Product product, int count, List<OrderLine> myShoppingCart)
        {
            var existingOrderLine = FindOrderLine(product, myShoppingCart);

            if (existingOrderLine != null)
            {
                existingOrderLine.addCount(count);
            }
            else
            {
                OrderLine myOrderLine = new OrderLine(product, count);
                myShoppingCart.Add(myOrderLine);
            }

            Console.WriteLine($"Du kjøpte {count} stk. {product}");
        }

        private static OrderLine? FindOrderLine(Product product, List<OrderLine> myShoppingCart)
        {
            OrderLine existingOrderLine = null;

            foreach (var orderLine in myShoppingCart)
            {
                if (orderLine.Product == product)
                {
                    existingOrderLine = orderLine;
                }
            }

            return existingOrderLine;
        }

        private static void ShowCart(Product[] aProducts, List<OrderLine> aMyShoppingCart)
        {
            if (aMyShoppingCart.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;

            for (int i = 0; i < aMyShoppingCart.Count; i++)
            {
                var count = aMyShoppingCart[i].Count;
                var productName = aProducts[i].Name;
                var price = aMyShoppingCart[i].Product.Price;
                var orderLinePrice = price * count;
                Console.WriteLine($"  {count} stk. {productName} a kr {price} = {orderLinePrice}");
                totalPrice += orderLinePrice;
            }

            Console.WriteLine($"Totalpris: {totalPrice}");
        }

        //private static int PriceFromProductName(Product[] products, string productName)
        //{
        //    var productIndex = Array.IndexOf(products, productName);
        //    var price = products[productIndex];
        //    return price;
        //}
    }
}
