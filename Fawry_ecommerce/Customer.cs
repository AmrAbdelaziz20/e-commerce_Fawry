using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_ecommerce
{
    internal class Customer
    {
        public string Name { get; set; }
        public double AmountOFmoney { get; set; }
        public List<Cart> cart {  get; set; }
        public Customer(string name , double amountofmoney) {
            Name = name;
            AmountOFmoney = amountofmoney;
            cart = new List<Cart>();
        }
    }
}
