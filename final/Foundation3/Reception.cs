public class Reception : Event
{
    // Private field to store reception-specific details.
    private string _email;

    // Constructor to initialize reception properties.
    public Reception(string title, string description, string date, string time, string type, Address address, string email) : base(title, description, date, time, type, address)
    {
        // Initialize reception-specific properties with values provided.
        _email = email;
    }

    // Method to return full details of the reception event as a formatted string.
    public string FullDetails()
    {
        // Format the full details of the reception event including standard event details and RSVP email.
        string fullString = $"Title: {Title} \nDescription: {Description} \nDate: {Date} \nTime: {Time} \nAddress: {Address.DisplayAddress()} \nType of Event: {Type} \nEmail for RSVP: {_email}";
        return fullString;
    }
}