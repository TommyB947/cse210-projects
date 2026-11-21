using System;

class Program
{
    static void Main(string[] args)
    {
        //products
        Product product1 = new Product("Shaving Cream", "114838B345", 2, 19.36f);
        Product product2 = new Product("Bouncy Ball", "1234ABC1234", 10, 5.99f);
        Product product3 = new Product("XBox Controller", "999ZZZ999", 2, 39.99f);
        Product product4 = new Product("Carrots", "4432CTI345", 1, 8.99f);
        Product product5 = new Product("60 inch TV", "CCTTVV99876BTC", 1, 199.99f);
        Product product6 = new Product("Hamburger", "33221HAMburger12333", 1, 3.43f);

        //customer
        Address address1 = new Address("2603 5th Street", "Chicago", "Illinois", "USA");
        Customer customer1 = new Customer("Jeff Hawk", address1);
        Address address2 = new Address("5103 North County Rd.", "Mattoon", "Texas", "United States");
        Customer customer2 = new Customer("Jane Doe", address2);
        Address address3 = new Address("4401 N Real Road", "Toronto", "Ontario", "Canada");
        Customer customer3 = new Customer("John Doe", address3);
        
        //orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product3);
        order3.AddProduct(product5);

        //print statements to console
        Console.Clear();

        Console.WriteLine($"Price: {order1.OrderCost()}");
        Console.WriteLine($"Shipping Label: {order1.ShippingLabel()}");
        Console.WriteLine($"Packing Label: {order1.PackingLabel()}");

        Console.WriteLine($"Price: {order2.OrderCost()}");
        Console.WriteLine($"Shipping Label: {order2.ShippingLabel()}");
        Console.WriteLine($"Packing Label: {order2.PackingLabel()}");

        Console.WriteLine($"Price: {order3.OrderCost()}");
        Console.WriteLine($"Shipping Label: {order3.ShippingLabel()}");
        Console.WriteLine($"Packing Label: {order3.PackingLabel()}");
    }
}