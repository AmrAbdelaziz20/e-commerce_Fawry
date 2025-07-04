using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fawry_ecommerce
{
    internal class Shippable_Product : Product, IShippalble
    {
        public double Weight { get; set; }

        public Shippable_Product(string name, double price, int quantity, double weight)
            : base(name, price, quantity)
        {
            Weight = weight;
        }

        public string Getname()
        {
            return Name;
        }
        public double Getweight() => Weight;
    }
}
