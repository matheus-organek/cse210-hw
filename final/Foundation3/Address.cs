public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to initialize address properties.
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to display the complete address as a formatted string.
    public string DisplayAddress()
    {
        // Concatenate address fields into a formatted string.
        string addressString = $"Street: {_streetAddress} \nCity: {_city} \nState: {_state} \nCountry: {_country}";
        return addressString; // Return the formatted address string.
    }
}