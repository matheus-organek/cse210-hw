public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // Construtor
    public Lecture(string title, string description, string date, string time, string type, Address address, string speaker, int capacity) : base(title, description, date, time, type, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        string fullString = $"";
        return fullString;
    }
}