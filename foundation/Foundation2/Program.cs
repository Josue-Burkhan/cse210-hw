using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Roberth Rine", address1);

        Product product1 = new Product("Laptop", "L123", 1000, 1);
        Product product2 = new Product("Hard Disk 1T", "HD123", 200, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Address address2 = new Address("#1025 Los Incas", "Puno", "PUN", "Peru");
        Customer customer2 = new Customer("Max Gonzales", address2);

        Product product3 = new Product("Tablet", "T789", 500, 1);
        Product product4 = new Product("Ram Memory", "RM101", 100, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}


