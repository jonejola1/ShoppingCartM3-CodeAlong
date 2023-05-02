namespace ShoppingCart
{
    internal class OrderLine
    {
        public Product Product { get; private set; }
        public int Count { get; private set; }
        public int TotalPrice { get; private set; }

        public OrderLine(Product aProduct, int aCount)
        {
            Product = aProduct;
            Count = aCount;
        }

        public void AddCount(int aCount)
        {
            Count += aCount;
        }

        public int Show()
        {
            var count = Count;
            var productName = Product.Name;
            var price = Product.Price;
            var orderLinePrice = price * count;
            Console.WriteLine($"  {count} stk. {productName} for kr {price} = {orderLinePrice}");
            TotalPrice = orderLinePrice;
            return TotalPrice;
        }
    }
}
