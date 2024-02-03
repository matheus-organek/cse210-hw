// BreathingActivity class inherits from Activity class
public class BreathingActivity : Activity
{
    // Constructor for the BreathingActivity class.
    public BreathingActivity()
    {
        // Set the name and description of the breathing activity using setters inherited from Activity class.
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking your through breathing in and out slowly. " +
        "Clear your mind and focus on your breathing.";
    }

    // Method to run the breathing activity.
    public void Run()
    {
        // Displays the starting message.
        DisplayStartingMessage();

        // Displays a message with the spinner animation.
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        // Initialize remaining time with the total duration of the breathing activity.
        int remainingTime = Duration;
        // The loop that will continue running as long as there is still time remaining in the breathing activity, that is,
        // as long as the value of remainingTime is greater than zero.
        while (remainingTime > 0)
        {   
            // Countdown for 4 seconds for breathing in.
            ShowCountDown(4, "\nBreathe in... "); 

            // Countdown for 6 seconds for breathing out.
            ShowCountDown(6, "Now breathe out... "); 

            // Each breathing cycle takes 10 seconds, so 10 seconds is subtracted from the remaining time.
            remainingTime -= 10; 
        }

        // Display the ending message.
        DisplayEndingMessage();
        // Spinner animation for 5 seconds before returning to the menu.
        ShowSpinner(5);
    }
}