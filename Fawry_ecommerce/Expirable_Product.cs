using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_ecommerce
{
    internal class Expirable_Product:Product
    {
        public DateTime ExpiryDate { get; set; }
        public Expirable_Product(string name, double price, int quantity, DateTime expiryDate) : base(name, price, quantity)
        {
            ExpiryDate = expiryDate;
        }
        public override bool isexpired()
        {
            return DateTime.Now > ExpiryDate;
        }
    }
}
