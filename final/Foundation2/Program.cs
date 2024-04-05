using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
      // Create addresses
        Address address1 = new Address("321 Church St", "Greytown", "KZN", "South Africa");
        Address address2 = new Address("654 Frosthill Ave", "Lancetown", "GBR", "Botswana");

        // Create customers
        Customer customer1 = new Customer("Sibusiso Ndlela", address1);
        Customer customer2 = new Customer("Lucky Phakathi", address2);

        // Create products
        Product product1 = new Product("Laptop", "4567", 1000, 2);
        Product product2 = new Product("Phone", "9876", 600, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());


    }
}