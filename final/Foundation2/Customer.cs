using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public string Name => _name;
    public Address Address => _address;

    public bool LivesinUSA()
    {
        return _address.IsInUSA();
    }

}