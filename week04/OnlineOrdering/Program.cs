using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Toronto", "ON", "Canada");
        Customer customer1 = new Customer("Maria Paez", address1);

        
        Product product1 = new Product("Keyboard", "P-101", 1200.00, 1);
        Product product2 = new Product("Mouse", "P-102", 25.50, 2);

    
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

    
        Console.WriteLine("--------------------- Order 1 --------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine(); 

    
        Address address2 = new Address("54 Niagara St", "Provo", "UT", "USA");
        Customer customer2 = new Customer("Caroline White", address2);

        
        Product product3 = new Product("Keyboard", "P-201", 75.00, 1);
        Product product4 = new Product("Monitor", "P-202", 300.00, 1);
        Product product5 = new Product("Webcam", "P-203", 50.00, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("--------------------- Order 2 --------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine("--------------------------------------------------");
    }
}