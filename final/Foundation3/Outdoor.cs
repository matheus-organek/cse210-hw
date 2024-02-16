public class Outdoor : Event
{
    // Private field to store outdoor-specific details.
    private string _weatherStatement;

    // Constructor to initialize outdoor event properties.
    public Outdoor(string title, string description, string date, string time, string type, Address address, string weatherStatement) : base(title, description, date, time, type, address)
    {
        // Initialize outdoor-specific properties with values provided.
        _weatherStatement = weatherStatement;
    }

    // Method to return full details of the outdoor event as a formatted string.
    public string FullDetails()
    {
        // Format the full details of the outdoor event including standard event details and weather statement.
        string fullString = $"Title: {Title} \nDescription: {Description} \nDate: {Date} \nTime: {Time} \nAddress: {Address.DisplayAddress()} \nType of Event: {Type} \nWeather Statement: {_weatherStatement}";
        return fullString;
    }
}