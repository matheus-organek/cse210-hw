public class Lecture : Event
{
    // Private fields to store lecture-specific details.
    private string _speaker;
    private int _capacity;

    // Constructor to initialize lecture properties.
    public Lecture(string title, string description, string date, string time, string type, Address address, string speaker, int capacity) : base(title, description, date, time, type, address)
    {
        // Initialize lecture-specific properties with values provided.
        _speaker = speaker;
        _capacity = capacity;
    }

    // Method to return full details of the lecture event as a formatted string.
    public string FullDetails()
    {
        // Format the full details of the lecture event including standard event details, speaker name, and capacity.
        string fullString = $"Title: {Title} \nDescription: {Description} \nDate: {Date} \nTime: {Time} \nAddress: {Address.DisplayAddress()} \nType of Event: {Type} \nSpeaker Name: {_speaker} \nCapacity: {_capacity}";
        return fullString;
    }
}