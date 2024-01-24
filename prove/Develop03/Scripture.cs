public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string scriptureString = $"";
        return scriptureString;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}