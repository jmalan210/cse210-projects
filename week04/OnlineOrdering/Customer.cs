public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool Domestic()
    {
        bool domestic = _address.InUSA();
        return domestic;
    }

    public string DisplayCustomerName()
    {
        string customerName = _customerName;
        return customerName;
    }

    public string DisplayCustomerAddress()
    {
        string customerAddress = _address.DisplayAddress();
        return customerAddress;
    }
}