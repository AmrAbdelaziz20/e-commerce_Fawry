using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_ecommerce
{
    internal class Cart
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public Cart(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public double Tprice => (double)(Product.Price * Quantity);


    }
}
