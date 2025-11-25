using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K001", 25.99, 1));
        order1.AddProduct(new Product("Mouse", "M150", 15.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");


        Address address2 = new Address("45 Calle Sur", "Monterrey", "NL", "Mexico");
        Customer customer2 = new Customer("Maria Lopez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "L900", 750, 1));
        order2.AddProduct(new Product("USB Cable", "U020", 5, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
