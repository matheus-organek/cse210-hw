public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize a Word object with a given text.
    public Word(string text)
    {
        _text = text;  // Initializes the text of the word.
        _isHidden = false;  // Initializes the word as not hidden.
    }

    // Method to hide the word.
    public void Hide()
    {
        _isHidden = true;  // Sets the word as hidden.
    }

    // Method to show the word.
    public void Show()
    {
        _isHidden = false;  // Sets the word as not hidden.
    }
    
    // Method to check if the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;  // Returns whether the word is hidden or not.
    }

    // Method to get the display text of the word, showing underscores if the word is hidden.
    public string GetDisplayText()
    {
        if (_isHidden)  // If the word is hidden.
        {
            return new string('_', _text.Length);  // Returns a string of underscores with the same length as the word.
        }
        
        else  // If the word is not hidden.
        {
            return _text;  // Returns the original text of the word.
        }
    }
}