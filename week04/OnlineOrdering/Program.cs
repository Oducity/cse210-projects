using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("21N Rodeo Drive,", "Los Angeles", "California", "usa");
        Address address2 = new Address("6 Okugbe street,", "Benin City", "Edo State", "Nigeria");

        Order order = new Order();
    }
}