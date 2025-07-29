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

    public void GetPackingLabel()
    {
        Console.WriteLine($"Product Id: {_id}, Product Name: {_name}, Product Price: ${_price}, Product Quantity: {_quantity}{Environment.NewLine}Product Amount: ${_price * _quantity}");
    }
}