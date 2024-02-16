public class Event
{
    // Private fields to store event details.
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address;

    // Constructor to initialize event properties.
    public Event(string title, string description, string date, string time, string type, Address address)
    {
        // Initialize event properties with values provided.
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    // Method to return standard details of the event as a formatted string.
    public string StandardDetails()
    {
        // Format the standard details of the event including title, description, date, time, and address.
        string standardString = $"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.DisplayAddress()}";

        return standardString;
    }

    // Method to return short description of the event as a formatted string.
    public string ShortDescription()
    {   
        // Format the short description of the event including type, title, and date.
        string shortString = $"Type of Event: {_type} \nTitle: {_title} \nDate: {_date}";

        return shortString;
    }

    // Getters and setters for the _name variable.
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    // Getters and setters for the _description variable.
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    // Getters and setters for the _date variable.
    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    // Getters and setters for the _time variable.
    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }

    // Getters and setters for the _type variable.
    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    // Getters and setters for the _address variable.
    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
}