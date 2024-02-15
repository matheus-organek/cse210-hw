using System;

class Program
{
    static void Main(string[] args)
    {
        // Create customers.
        Address customerAddress1 = new Address("108 Alaor St", "Curitiba", "PR", "BRA");
        Customer customer1 = new Customer("Matheus Organek", customerAddress1);

        Address customerAddress2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Customer customer2 = new Customer("Joe Kinsgley", customerAddress2);

        // Create products.
        Product product1 = new Product("Watch", "W-1001", 50.0, 2);
        Product product2 = new Product("Notebook", "G-1002", 500.00, 1);
        Product product3 = new Product("Suitcase", "S-1003", 50.0, 4);
        Product product4 = new Product("Tie", "T-1004", 15.0, 7);
        Product product5 = new Product("Headset", "H-1005", 50.0, 3);

        // Create orders.
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product5);

        // Cleans the console.
        Console.Clear();

        // Display packing labels, shipping labels, and total prices for the orders.
        Console.WriteLine("> Order 1");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalOrderCost()}\n");

        Console.WriteLine("> Order 2");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalOrderCost()}\n");
    }
}