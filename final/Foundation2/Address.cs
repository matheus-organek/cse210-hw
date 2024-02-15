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

    // Method to check if the address is in the USA.
    public bool IsInUsa()
    {
        if (_country != null && _country.Equals("USA", StringComparison.OrdinalIgnoreCase)) // Check if the country is not null and is "USA" (case-insensitive).
        {
            return true;  // Return true if the address is in the USA.
        }
        else
        {
            return false; // Return false if the address is not in the USA.
        }
    }

    // Method to display the complete address as a formatted string.
    public string DisplayAddress()
    {
        // Concatenate address fields into a formatted string.
        string addressString = $"Street: {_streetAddress} \nCity: {_city} \nState: {_state} \nCountry: {_country}";
        return addressString; // Return the formatted address string.
    }
}