public class Order
{
    private List<Product> _products = new List<Product>();
    Customer _customer;

    public Order(Product product, Customer customer)
    {
        _customer = customer;
        _products.Add(product);
    }

    
}