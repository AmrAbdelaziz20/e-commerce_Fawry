using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_ecommerce
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public virtual bool isexpired()
        {
            return false;
        }

        //public void ReduceQuantity(int amount)
        //{
        //    if (amount > Quantity)
        //        throw new InvalidOperationException("Insufficient stock.");
        //    Quantity -= amount;
        //}


    }
}
