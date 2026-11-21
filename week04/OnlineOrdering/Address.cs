using System;
using System.Reflection.Metadata.Ecma335;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;



    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }



    public bool IsUS()
    {
        bool IsUS;
        if (_country == "United States" || _country == "USA" || _country == "US" || _country == "United States of America" || _country == "America")
        {
            IsUS = true;
        }
        else
        {
            IsUS = false;
        }
        return IsUS;
    }

    public string GetAddressText()
    {
        string address = $"{_streetAddress} {_city} {_state} {_country}";
        return address;
    }
}