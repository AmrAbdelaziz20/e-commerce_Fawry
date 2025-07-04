using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_ecommerce
{
    internal class ECommerceSystem
    {
        private Shipping_Service shipping_service =new Shipping_Service();

        public void Add_to_cart(Customer customer, Product product, int quantity)
        {
            if (quantity > product.Quantity)
            {
                Console.WriteLine("the amount you want ,isn't available in the stock");
            }
            else
            {
                customer.cart.Add(new Cart(product, quantity));
                Console.WriteLine($"{quantity} of {product.Name} add tocart ");

            }
        }
        public void checkout(Customer customer) {

            if (customer.cart != null)
            {
                double totalbeforeshipping = 0;
                List<IShippalble> shippalble_items = new List<IShippalble>();
                foreach (var item in customer.cart) { 
                    if(item.Product.Quantity < item.Quantity)
                    {
                        Console.WriteLine($"{item.Product.Name} is out of stock");
                        return;
                    }
                    if (item.Product.isexpired())
                    {
                        Console.WriteLine($"{item.Product.Name} is expired");
                        return;

                    }
                    if (item.Product is IShippalble shippable)
                    {
                        shippalble_items.Add(shippable);
                    }
                    totalbeforeshipping += item.Tprice;
                    //we assumed that counted shipple item * 15  that the shipping cost
                    double shipping_cost = shippalble_items.Count * 15;
                    double total = shipping_cost + totalbeforeshipping;
                    if (customer.AmountOFmoney < total)
                    {
                        Console.WriteLine("sorry you don't have enough money");
                    }
                    else
                    {
                        customer.AmountOFmoney-=total;
                    }
                    foreach (var item2 in customer.cart)
                    {
                        item2.Product.Quantity -= item2.Quantity;
                    }
                    Console.WriteLine($"total: {totalbeforeshipping} EGP");
                    Console.WriteLine($"Shipping Fee: {shipping_cost} EGP");
                    Console.WriteLine($"Total Paid: {total} EGP");
                    Console.WriteLine($"Remaining Balance: {customer.AmountOFmoney} EGP");
                    if (shippalble_items.Count>0)
                    {
                        shipping_service.Item_shipping(shippalble_items);
                    }
                    customer.cart.Clear();
                    

                }

            }
            else
            {
                Console.WriteLine("YOUR CART IS EMPTY");
            }
        }
    }
}
