using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer; //= new List<Customer>();

    public Order(Product product1, Product product2, Product product3, Customer customer)
    {
        _customer = customer;
        _products.Add(product1);
        _products.Add(product2);
        _products.Add(product3);
    }

    public void GetShippingLabel()
    {
            Console.WriteLine($"Shipping Label:{Environment.NewLine}{_customer.GetCustomerName()}{Environment.NewLine}{_customer.GetAddress()}{Environment.NewLine}Delivery Charge for {_customer.GetLocation()} : ${_customer.GetDeliveryCharge()}");
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label:");
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetProductTotal();
            Console.WriteLine($"{p.GetPackingLabel()}");
        }
        Console.WriteLine($"The Total Amount for Your Order: ${total}");
    }    
}
