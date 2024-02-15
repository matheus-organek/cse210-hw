public class Comment
{
    private string _name;
    private string _text;

    // Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Getter for comment name
    public string GetName()
    {
        return _name;
    }

    // Getter for comment text
    public string GetText()
    {
        return _text;
    }
}