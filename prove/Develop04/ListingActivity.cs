// ListingActivity class inherits from Activity class
public class ListingActivity : Activity
{
    // Declares private variables to store count and prompts for listing.
    private int _count;
    private List<string> _prompts;

    // Constructor for the ListingActivity class.
    public ListingActivity()
    {
        // Set the name and description of the listing activity using setters inherited from Activity class.
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        // Initializes the count varible.
        _count = 0;

        // Initializes the list of prompts for listing.
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Method to run the listing activity.
    public void Run()
    {
        // Display the starting message of the listing activity.
        DisplayStartingMessage();

        // Show spinner animation for 5 seconds.
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        // Display the prompt for listing.
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        // Start the countdown for listing.
        ShowCountDown(5, "You may begin in: ");

        // Prompt the user to press Enter after each response.
        Console.WriteLine("\nPress Enter after each response. Time is ticking...");

        // Collects user responses.
        List<string> userResponses = GetListFromUser();

        // Display the count of user responses.
        Console.WriteLine($"You listed {userResponses.Count} items!");

        // Display the ending message of the listing activity.
        DisplayEndingMessage();
        // Show spinner animation for 5 seconds before returning to the menu.
        ShowSpinner(5);
    }

    // Method to get a random prompt for listing.
    public void GetRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        // Display the random prompt.
        Console.WriteLine($"\n --- {randomPrompt} ---");
    }

    // Method to get responses from the user.
    public List<string> GetListFromUser()
    {
        List<string> userResponses = new List<string>();

        // Record start time for timing user input.
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {   
            // For the user's inputs.
            Console.Write("> ");
            // Read user response.
            string response = Console.ReadLine();
            // Add user response to the list.
            userResponses.Add(response);
            // Increment count of responses.
            _count++;
        }
        return userResponses;
    }
}