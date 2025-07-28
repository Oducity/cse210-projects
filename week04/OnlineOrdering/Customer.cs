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
        return ad.CheckLocation();
    }
}