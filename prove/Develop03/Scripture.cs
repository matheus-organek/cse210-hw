public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // The Scripture Class constructor.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;   // Initializes the scripture reference.
        _words = new List<Word>();  // Initializes the list of words in the scripture.

        // Reads, separates and adds each text word in a list.
        string[] wordArray = text.Split(" ");
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));  // Adds a new Word instance to the words list.
        }
    }

    // A method to hide the words.
    public void HideRandomWords(int numberToHide)
    {
        // A random object is created.
        Random random = new Random();
        // A variable initialized to 0 is created to determine how many words are hidden.
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            // Randomly selects a word index in the list of words.
            int index = random.Next(0, _words.Count);

            // Checks if the word at the selected index is not hidden.
            if (!_words[index].IsHidden())
            {
                // If it's not hidden, hides the word and increments the count of hidden words.
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    // A method to get the display text.
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}"; // Initializes the display text with the scripture reference text.

        // Iterates over each word in the words list and adds its display text to the final text.
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;  // Returns the complete display text.
    }

    // A method to check if all words are completely hidden.
    public bool IsCompletelyHidden()
    {
        // Iterates over each word in the words list.
        foreach (Word word in _words)
        {
            // If it finds a word that is not hidden, returns false.
            if (!word.IsHidden())
                return false;
        }
        // If all words are hidden, returns true.
        return true; 
    }
}