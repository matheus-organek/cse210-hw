public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _type;
    private Address _address;

    public Event(string title, string description, string date, string time, string type, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public string StandardDetails()
    {
        string standardString = $"Title: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: {_address.DisplayAddress()}";

        return standardString;
    }

    public string ShortDescription()
    {   
        string shortString = $"Type of Event: {_type} \nTitle: {_title} \nDate: {_date}";

        return shortString;
    }
}