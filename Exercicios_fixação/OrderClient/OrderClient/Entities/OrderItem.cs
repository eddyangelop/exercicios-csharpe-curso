using OrderClient.Entities;
using System.Globalization;

namespace OrderClient.Entities
{
    class OrderItem
    {
        public Product Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        
       

        public OrderItem()
        {
        }

        public OrderItem(Product product, double price, int quantity )
        {
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}