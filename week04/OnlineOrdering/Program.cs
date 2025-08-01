using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("21 N Rodeo Drive,", "Los Angeles", "California", "U.S");
        Address address2 = new Address("6 Okugbe street,", "Benin City", "Edo State", "Nigeria");

        Product product1 = new Product("Laptop", 258854, 3200, 5);
        Product product2 = new Product("Van", 250054, 31200, 2);
        Product product3 = new Product("Printer", 206254, 800, 3);
        Product product4 = new Product("forklift", 266254, 45000, 1);
        Product product5 = new Product("Jak", 260654, 2200, 8);
        Product product6 = new Product("Paper Miller", 506254, 72000, 4);

        Customer customer1 = new Customer("Odumamwen Henry", address1);
        Customer customer2 = new Customer("Unicon Group of Company", address2);

        Console.Clear();
        Console.WriteLine("======================================================================");
        Order order1 = new Order(product1, product3, product6, customer1);
        order1.GetShippingLabel();
        order1.GetPackingLabel();

        Console.WriteLine("======================================================================");
        Order order2 = new Order(product2, product4, product5, customer2);
        order2.GetShippingLabel();
        order2.GetPackingLabel();

    }
}