using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_ecommerce
{
    internal class Shipping_Service
    {
        public void Item_shipping(List<IShippalble> Items)
        {
            Console.WriteLine("We will ship these items");
            foreach (var Item in Items)
            {
                Console.WriteLine($"- {Item.Getname()}, Weight: {Item.Getweight()} kg");
            }
        }
    }
}
