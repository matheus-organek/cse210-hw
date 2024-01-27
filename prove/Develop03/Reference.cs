public class Reference
{
    private string _book;
    private int _chapter;  
    private int _verse;  
    private int _endVerse;  


    // Constructor for references with only one verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;  
        _chapter = chapter;  
        _verse = verse;  

    }

    // Constructor for references with a range of verses.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;  
        _chapter = chapter;  
        _verse = startVerse;  
        _endVerse = endVerse;
    }

    // Method to get the display text of the reference.
    public string GetDisplayText()
    {   
        // Initializes the reference string with the book, chapter, and starting verse.
        string referenceString = $"\n{_book} {_chapter}:{_verse}";
        
        // Adds the ending verse if it exists.
        if (_endVerse != 0)
        {
            referenceString += $"-{_endVerse}";
        }
        
        return referenceString;  // Returns the reference string.
    }
}