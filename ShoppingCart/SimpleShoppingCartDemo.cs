namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            //var productNames = new[] { "A", "B", "C" };
            //var productPrices = new[] { 40, 70, 30 };

            var products = new Product[] {new Product("A", 40), new Product("B", 70), new Product("C", 30) };

            var myShoppingCart = new List<OrderLine>();
            

            //var myShoppingCartP = new List<Product>();
            //var myShoppingCartCounts = new List<int>();
            ShowCart(products, myShoppingCart);
            Buy("A", 1, myShoppingCart);
            ShowCart(products, myShoppingCart);
            Buy("B", 3, myShoppingCart);
            ShowCart(products, myShoppingCart);
            Buy("A", 4, myShoppingCart);
            ShowCart(products, myShoppingCart);
        }

        private static void Buy(string productName, int count, List<OrderLine> myShoppingCart)
        {
            if (myShoppingCart.Contains(productName))
            {
                var orderLineIndex = myShoppingCart.IndexOf(productName);
                myShoppingCart[orderLineIndex] += count;
            }
            else
            {
                myShoppingCart.Add(productName);
                myShoppingCart.Add(count);
            }

            Console.WriteLine($"Du kjøpte {count} stk. {productName}");
        }
        //OrderLine is empty and show cart adds the elements to the List<>
        private static void ShowCart(Product[] aProducts, List<OrderLine> aMyShoppingCart)
        {
            if (aMyShoppingCart.Count == 0)
            {
                Console.WriteLine("Handlekurven er tom.");
                return;
            }

            Console.WriteLine("Handlekurv:");
            var totalPrice = 0;

            foreach (var product in aProducts)
            {
                var count = aProducts[i];
                var productName = aProducts[i];
                var price = PriceFromProductName(aProducts, productName);
                var orderLinePrice = price * count;
                Console.WriteLine($"  {count} stk. {productName} a kr {price} = {orderLinePrice}");
                totalPrice += orderLinePrice;
            }

            //for (int i = 0; i < aProducts.Length; i++)
            //{
            //    var count = aMyShoppingCart[i];
            //    var productName = aProducts[i];
            //    var price = PriceFromProductName(aProducts, productName);
            //    var orderLinePrice = price * count;
            //    Console.WriteLine($"  {count} stk. {productName} a kr {price} = {orderLinePrice}");
            //    totalPrice += orderLinePrice;
            //}

            Console.WriteLine($"Totalpris: {totalPrice}");
        }

        private static int PriceFromProductName(Product[] products, string productName)
        {
            var productIndex = Array.IndexOf(products, productName);
            var price = products[productIndex];
            return price;
        }
    }
}
