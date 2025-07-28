public class Customer
{
    private string _name;
    private Address _address;


    public Customer(string name, Address adr)
    {
        _name = name;
        _address = adr;
    }


    public bool Location()
    {
        Address ad = new Address();
        return ad.SetDeliveryCharge();
    }

    public void DisplayCustomerName()
    {
        Console.WriteLine($"Customer: {_name}");
    }

    public double GetDeliveryCharge()
    {
        Address ad = new Address();
        return ad.GetDeliveryCharge();
    }
}