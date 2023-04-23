using System.Data;

namespace ShoppingCart
{
    internal class ShoppingCart
    {

        public bool PromtUser(List<OrderLine> aMyShoppingCart)
        {
            Console.Clear();
            Console.WriteLine("Make a product to add to cart.");
            Console.WriteLine("What is the product name?");
            var productNameInput = Console.ReadLine();
            string productName = Convert.ToString(productNameInput);
            Console.WriteLine("What is the price of the product");
            var productPriceinput = Console.ReadLine();
            int productPrice = Convert.ToInt32(productPriceinput);
            Console.WriteLine("quantity of product");
            var quantityOfProduct = Console.ReadLine();
            int productQuantity = Convert.ToInt32(quantityOfProduct);

            var productItem = new Product(productName, productPrice);
            var products = new OrderLine(productItem, productQuantity);

            AddToCart(productItem, productQuantity, aMyShoppingCart);
            ShowCart(products, aMyShoppingCart);

            Console.WriteLine("do you want to add more to your cart? y/n");
            ConsoleKeyInfo inputKey = Console.ReadKey();
            if (inputKey.KeyChar == 'y')
            {
                return true;
            }

            return false;
        }
        public void AddToCart(Product product, int count, List<OrderLine> myShoppingCart)
        {
            var existingOrderLine = FindOrderLine(product, myShoppingCart);

            if (existingOrderLine != null)
            {
                existingOrderLine.AddCount(count);
            }
            else
            {
                OrderLine myOrderLine = new OrderLine(product, count);
                myShoppingCart.Add(myOrderLine);
            }

            Console.WriteLine($"Du kjøpte {count} stk. {product}");
        }
        private OrderLine? FindOrderLine(Product product, List<OrderLine> myShoppingCart)
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

        public void ShowCart(OrderLine aProducts, List<OrderLine> aMyShoppingCart)
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
                var productName = aMyShoppingCart[i].Product.Name;
                var price = aMyShoppingCart[i].Product.Price;
                var orderLinePrice = price * count;
                Console.WriteLine($"  {count} stk. {productName} til kr {price} = {orderLinePrice}");
                totalPrice += orderLinePrice;
            }

            Console.WriteLine($"Totalpris: {totalPrice}");
        }
    }
}
