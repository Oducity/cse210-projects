public class Customer
{
    private string _name;
    private List<Address> _address = new List<Address>();


    public Customer()
    {

    }


    public bool Location()
    {
        Address ad = new Address();
        return ad.AddressLocation();
    }
}