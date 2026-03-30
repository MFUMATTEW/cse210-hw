using System.Formats.Asn1;
using System.Security.Cryptography;

public class Address
{
    private string _address;
    private string _city;
    private string _province;
    private string _country;

    public Address(string address, string city, string province, string country)
    {
        _address = address;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool GetCountry()
    {
        return _country.ToUpper()== "USA";    
    }
    
    public string GetFullAddress()
    {
        return $"{_address}, {_city}, {_province}/{_country}";
    }

    public void DisplayAddress()
    {
        Console.WriteLine(GetFullAddress());
    }

}