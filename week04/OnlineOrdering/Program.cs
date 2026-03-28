using System;
using System.Net.Http.Headers;
using System.Net.Sockets;


class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("Caldwell", "ID", "1717 Willow Lane", "", "USA");
        Customer cust1 = new Customer("Ichigo Suzuki", addr1);
        Order order1 = new Order(cust1);
        Product p1 = new Product("Strawberry box", "ABC0", 29.99, 1);
        order1.AddProduct(p1);


        Address addr2 = new Address("Moose Jaw", "Saskatchewan", "123 Moose Jaw Lane", "", "Canada");
        Customer cust2 = new Customer("Ted Bundy", addr2);
        Order order2 = new Order(cust2);
        Product p2 = new Product("Plaid Took", "PL123", 27.99, 2);
        order2.AddProduct(p2);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotalOrderCost():F2}");
        
        Console.WriteLine("\n---------------------------");

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotalOrderCost():F2}");
    }
}