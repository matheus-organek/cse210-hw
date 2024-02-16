public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize customer's name and address.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA.
    public bool LiveInUsa()
    {
        if (_address != null && _address.IsInUsa()) // Check if the address is not null and is in the USA.
        {
            return true;  // Return true if the customer lives in the USA.
        }
        else
        {
            return false; // Return false if the customer does not live in the USA.
        }
    }

    // Getters and setters for the _name variable.
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getters and setters for the _address variable.
    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
}