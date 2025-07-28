public class Product
{
    private string _name;
    private double _id;
    private double _price;
    private double _quantity;

    public Product(string name, double id, double price, double quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }
    
}