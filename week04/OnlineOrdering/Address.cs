using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;

    public Address(string city, string state, string street, string province, string country)
    {
        _street= street;
        _state = state;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool IsInUsa()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}\n{_state}";
    }
}