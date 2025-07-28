using System.Reflection.Metadata;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private double _deliveryCharges;

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

    public bool SetDeliveryCharge()
    {
        if (_country == "usa")
        {
            _deliveryCharges = 5;
            Console.WriteLine($"Delivery within the U>S: ${_deliveryCharges}");
            return true;
        }
        else
        {
            _deliveryCharges = 35;
            Console.WriteLine($"Delivery outside of U>S: ${_deliveryCharges}");
            return false;
        }
    }

    public double GetDeliveryCharge()
    {
        return _deliveryCharges;
    }


    public string GetAddress()
    {
        return $"{_street}{Environment.NewLine}{_city}, {_state},{Environment.NewLine}{_country}.";
    }
}