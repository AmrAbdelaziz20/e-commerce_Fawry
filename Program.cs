using Fawry_ecommerce;

internal class Program
{
    private static void Main(string[] args)
    {
        var customer = new Customer("Amr", 500);
        var cheese = new Shippable_Product("Cheese", 30, 10, 2);

        var scratchCard = new Product("Mobile Scratch Card", 10, 20);
        var biscuit = new Expirable_Product("Biscuit", 15, 5, DateTime.Now.AddDays(1));

        var system = new ECommerceSystem();
        system.Add_to_cart(customer, cheese, 2);
        system.Add_to_cart(customer, scratchCard, 3);
        system.Add_to_cart(customer, biscuit, 1);

        system.checkout(customer);
    }
}