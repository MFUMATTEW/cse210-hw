using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(Address address, string name)
    {
       _address = address;
       _name = name;

    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool Country()
    {
        return _address.GetCountry();
    }

    public void DisplayCustomer()
    {
        Console.WriteLine($"{_name}");
        _address.DisplayAddress();
    }


    

}