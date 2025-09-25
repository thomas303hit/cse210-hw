using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

            // Create customers
            Customer customer1 = new Customer("John", address1);
            Customer customer2 = new Customer("Gabriel", address2);

            // Create products
            Product product1 = new Product("Laptop", "LAP123", 999.99, 1);
            Product product2 = new Product("Mouse", "MOU456", 29.99, 2);
            Product product3 = new Product("Keyboard", "KEY789", 59.99, 1);
            Product product4 = new Product("Monitor", "MON012", 199.99, 1);
            Product product5 = new Product("Headphones", "HPN345", 79.99, 3);

            // Create order 1 (USA)
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            // Create order 2 (Canada)
            Order order2 = new Order(customer2);
            order2.AddProduct(product4);
            order2.AddProduct(product5);

            // Display order details
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        }
    }
}