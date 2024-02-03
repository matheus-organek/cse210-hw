// ReflectingActivity class inherits from Activity class
public class ReflectingActivity : Activity
{
    // Declares private variables to store prompts and questions for reflection.
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor for the ReflectingActivity class.
    public ReflectingActivity()
    {
        // Set the name and description of the reflecting activity using setters inherited from Activity class.
        Name = "Reflection Activity";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        // Initialize lists of prompts and questions for reflection.
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string> 
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Method to run the reflecting activity.
    public void Run()
    {
        // Display the starting message of the reflecting activity.
        DisplayStartingMessage();

        // Show spinner animation for 5 seconds.
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        // Display the prompt for reflection.
        Console.WriteLine("\nConsider the following prompt:");
        DisplayPrompt();

        // Loop to wait for the user confirmation.
        bool loop = true;
        while (loop)
        {
            Console.Write("\nWhen you have something in mind, press enter to continue. ");
            string input = Console.ReadLine().Trim();
            loop = false;
        }
        
        // Prompt the user to ponder on each question related to the experience.
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");

        // Start the countdown for reflection.
        ShowCountDown(5, "You may begin in: ");
        
        // Clear the console screen.
        Console.Clear();

        // Display the reflection questions.
        DisplayQuestions();

        // Display the ending message of the reflecting activity.
        DisplayEndingMessage();
        // Show spinner animation for 5 seconds before returning to the menu.
        ShowSpinner(5);
    }

    // Method to get a random prompt for reflection.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    // Method to get a random question for reflection.
    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    // Method to display a random prompt for reflection.
    public void DisplayPrompt()
    {   
        // Get a random prompt for reflection.
        string randomPrompt = GetRandomPrompt();
        
        // Display the random prompt.
        Console.WriteLine($"\n --- {randomPrompt} ---");
    }

    // Method to display reflection questions.
    public void DisplayQuestions()
    {   
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < Duration)
        {
            // Get a random question for reflection.
            string randomQuestion = GetRandomQuestion();

            // Display the random question.
            Console.WriteLine($"> {randomQuestion}");

            // Remove the question from the list to ensure it is not repeated.
            _questions.Remove(randomQuestion);

            // Show the spinner for 5 seconds for each question.
            ShowSpinner(5);
        }
    }
}