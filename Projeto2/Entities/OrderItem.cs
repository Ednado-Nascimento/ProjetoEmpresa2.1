using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Entities
{
    internal class OrderItem
    {
        public double Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(double quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
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
