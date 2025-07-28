using System.Reflection.Metadata;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CheckLocation()
    {
        if (_country == "usa")
        {
            Console.WriteLine("Yes");
            return true;
        }
        else
        {
            Console.WriteLine("No");
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}{Environment.NewLine}{_city}, {_state},{Environment.NewLine}{_country}.";
    }
}