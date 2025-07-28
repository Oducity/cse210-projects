using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _products = new List<Product>();
    Customer _customer;

    public Order(Product product1, Product product2, Product product3, Customer customer)
    {
        _customer = customer;
        _products.Add(product1);
        _products.Add(product2);
        _products.Add(product3);
    }
}