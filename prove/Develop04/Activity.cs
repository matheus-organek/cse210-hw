// Declares a class named Activity.
public class Activity
{
    // Declares private variables to store the name, description, and duration of the activity.
    private string _name;
    private string _description;
    private int _duration;

    // Constructor for the Activity class with no parameters.
    public Activity()
    {
        // Initializes the name, description, and duration fields with default values.
        _name = "";
        _description = "";
        _duration = 0;
    }

    // Method to display the starting message of the activity.
    public void DisplayStartingMessage()
    {
        // Cleans the console.
        Console.Clear();

        // Displays a welcome message with the name of the activity.
        Console.WriteLine($"Welcome to the {_name}.");
      
        // Displays the description of the activity.
        Console.WriteLine($"\n{_description}");
        
        // Asks the user to input the duration.
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        // Reads the user input and parses it to an integer, storing it in _duration.
        _duration = int.Parse(Console.ReadLine());

        // Pauses the program execution for 5 seconds.
        ShowSpinner(5);

        // Cleans the console.
        Console.Clear();
    }

    // Method to display the ending message of the activity.
    public void DisplayEndingMessage()
    {
        // Displays a congratulatory message.
        Console.WriteLine("\nWell done!");
      
        // Displays the completed duration and the name of the activity.
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
    }

    // Method to show a spinner animation.
    public void ShowSpinner(int seconds)
    {
        // Declares a list of spinner animation characters.
        List<string> spinnerAnimation = new List<string> {"|", "/", "-", "\\"};

        // Calculates the number of iterations based on the input seconds.
        int iterations = seconds * 2;
        // Iterates through the spinner animation for the calculated number of iterations.
        for (int i = 0; i < iterations; i++)
        {
            // Selects the spinner animation character based on the current iteration.
            string spinner = spinnerAnimation[i % spinnerAnimation.Count];
            // Displays the spinner animation character.
            Console.Write(spinner);
            // Pauses the program execution for 1 second.
            Thread.Sleep(1000);
            // Moves the cursor back and erases the spinner animation character.
            Console.Write("\b \b");
        }
    }

    // Method to show a countdown.
    public void ShowCountDown(int seconds, string prompt)
    {
        // Displays the prompt.
        Console.Write($"\n{prompt}");

        // Iterates from the input seconds to 1.
        for (int i = seconds; i > 0; i--)
        {
            // Displays the current countdown value.
            Console.Write(i);
            // Pauses the program execution for 1 second.
            Thread.Sleep(1000);
            // Moves the cursor back and erases the countdown animation character.
            Console.Write("\b \b");
        }
    }

    // Getters and setters for the _name variable.
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Getters and setters for the _description variable.
    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    // Getters and setters for the _duration variable.
    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }
}