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

    public bool CheckLocation()
    {
        if (_country == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}{Environment.NewLine}{_city}, {_state},{Environment.NewLine}{_country}.";
    }
}