class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsInCANADA()
    {
        return _address.IsInCANADA();
    }

    public Address GetAddress()
    {
        return _address;
    }
}