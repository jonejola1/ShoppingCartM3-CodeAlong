﻿namespace ShoppingCart
{
    internal class SimpleShoppingCartDemo
    {
        public static void Run()
        {
            var A = new Product("A", 40);
            var B = new Product("B", 70);
            var C = new Product("C", 30);
            var products = new Product[] { A, B, C };

            var myCart = new List<OrderLine>();
            var shoppingCart = new ShoppingCart();

            

            shoppingCart.Show();
            shoppingCart.Add(A, 1);

            shoppingCart.Show();
            shoppingCart.Add(B, 3);

            shoppingCart.Show();
            shoppingCart.Add(A, 4);
            shoppingCart.Show();
        }
    }
}
