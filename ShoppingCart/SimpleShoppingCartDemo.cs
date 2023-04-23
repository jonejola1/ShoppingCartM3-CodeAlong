using System.ComponentModel;
using System.Net.WebSockets;

namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            var myShoppingCart = new List<OrderLine>();
            var myCart = new ShoppingCart();
            Console.WriteLine("Add to cart or quit y/n");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == 'y')
            {
                do
                {
                    myCart.PromtUser(myShoppingCart);
                } while (true);

            }
        }
    }
}