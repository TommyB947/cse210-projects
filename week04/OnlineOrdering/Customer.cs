using System;
using System.Net.Sockets;
using System.Reflection.Metadata;

class Customer
{
    private string _name;
    private Address _address;



    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUS()
    {
        bool US = _address.IsUS();
        return US;
    }

    public string GetCustomerText()
    {
        string text;
        text = $"{_name} - {_address.GetAddressText()}";
        return text;
    }
}