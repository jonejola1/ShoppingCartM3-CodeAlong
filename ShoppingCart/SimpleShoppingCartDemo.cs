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
            var input = Console.ReadLine();
            if (input == "y")
            {
                var doWhile = true;
                while (doWhile)
                {
                    doWhile = myCart.PromtUser(myShoppingCart);
                }
            }
            else return;
        }
    }
}