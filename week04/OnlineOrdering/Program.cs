using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
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


        Order order1 = new Order(product1, product3, product6, customer1);
        
        bool addr = address1.SetDeliveryCharge();
        if (addr == true)
        {
            customer1.DisplayCustomerName();
            address1.GetLocation();
            product1.GetPackingLabel();
            product3.GetPackingLabel();
            product6.GetPackingLabel();
            Console.WriteLine($"Goods Charge: ${product1.GetTotalCost() + product3.GetTotalCost() + product6.GetTotalCost()}");
            Console.WriteLine($"Delivery charge within the U.S is ${address1.GetDeliveryCharge()}");
            Console.WriteLine($"Total Charge: ${product1.GetTotalCost() + product3.GetTotalCost() + product6.GetTotalCost() + address1.GetDeliveryCharge()}");
        }
        else
        {
            customer1.DisplayCustomerName();
            address1.GetLocation();
            product3.GetPackingLabel();
            product3.GetPackingLabel();
            product3.GetPackingLabel();
            Console.WriteLine($"Goods Charge: ${product1.GetTotalCost() + product3.GetTotalCost() + product6.GetTotalCost()}");
            Console.WriteLine($"Delivery charge outside the U.S is ${address1.GetDeliveryCharge()}");
            Console.WriteLine($"Total Charge: ${product1.GetTotalCost() + product3.GetTotalCost() + product6.GetTotalCost() + address1.GetDeliveryCharge()}");
        }

        Console.WriteLine("======================================================================");

        Order order2 = new Order(product2, product4, product5, customer2);
        bool addr2 = address2.SetDeliveryCharge();
        if (addr2 == true)
        {
            customer2.DisplayCustomerName();
            address2.GetLocation();
            product2.GetPackingLabel();
            product4.GetPackingLabel();
            product5.GetPackingLabel();
            Console.WriteLine($"Goods Charge: ${product2.GetTotalCost() + product4.GetTotalCost() + product5.GetTotalCost()}");
            Console.WriteLine($"Delivery charge within the U.S is ${address2.GetDeliveryCharge()}");
            Console.WriteLine($"Total Charge: ${product2.GetTotalCost() + product4.GetTotalCost() + product5.GetTotalCost() + address2.GetDeliveryCharge()}");
        }
        else
        {
            customer2.DisplayCustomerName();
            address2.GetLocation();
            product2.GetPackingLabel();
            product4.GetPackingLabel();
            product5.GetPackingLabel();
            Console.WriteLine($"Goods Charge: ${product2.GetTotalCost() + product4.GetTotalCost() + product5.GetTotalCost()}");
            Console.WriteLine($"Delivery charge outside the U.S is ${address2.GetDeliveryCharge()}");
            Console.WriteLine($"Total Charge: ${product2.GetTotalCost() + product4.GetTotalCost() + product5.GetTotalCost() + address2.GetDeliveryCharge()}");
        }
    }
}