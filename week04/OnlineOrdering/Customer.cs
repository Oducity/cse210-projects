public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address adr)
    {
        _name = name;
        _address = adr;
    }


    public string GetLocation()
    {
        return _address.GetLocation();
    }

    public string GetCustomerName()
    {
        return $"Customer: {_name}";
    }

    public double GetDeliveryCharge()
    {
        return _address.GetDeliveryCharge();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}