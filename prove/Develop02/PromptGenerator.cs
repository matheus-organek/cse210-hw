public class PromptGenerator 
{
    // List of available prompts
    public List<string> _prompts;

    // Set to track used prompts
    public HashSet<string> _usedPrompts;

    // Constructor that initializes the prompt list and used prompts set
    public PromptGenerator ()
    {
        _prompts = new List<string>();
        _usedPrompts = new HashSet<string>();

        // Adding prompts to the list
        _prompts.Add("What did I learn today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was I grateful for today and how can I help someone else be grateful too?");
        _prompts.Add("Who did I pray for today and why?");
        _prompts.Add("What did I do wrong today and want to apologize tomorrow to improve?");
    }

    // Method to get a random prompt that has not been used
    public string GetRandomPrompt()
    {
        // Check if all prompts have been used, if yes, return null
        if (_usedPrompts.Count == _prompts.Count)
        {
            return null;
        }

        // Random number generator
        Random randomGenerator = new Random();
        string randomPrompt;

        // Get a random prompt that has not been used
        do
        {
            int index = randomGenerator.Next(0, _prompts.Count);
            randomPrompt = _prompts[index];
        } while (_usedPrompts.Contains(randomPrompt));

        // Mark the prompt as used
        _usedPrompts.Add(randomPrompt);

        return randomPrompt;
    }
}