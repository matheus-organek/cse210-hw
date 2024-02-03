// I implemented a line of code to remove questions already asked in a Reflection Class session.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize userChoice variable to control menu selection.
        int userChoice = 0;

        // Display menu options until the user chooses to quit.
        while (userChoice != 4)
        {
            // Clear the console screen.
            Console.Clear();

            // Display menu options.
            Console.WriteLine("Menu options:" +
                            "\n   1. Start Breathing Activity" +
                            "\n   2. Start Reflecting Activity" +
                            "\n   3. Start Listing Activity" +
                            "\n   4. Quit");

            // Prompt the user to select an option from the menu.
            Console.Write("Select a choice from the menu: ");
            // Read the user's choice from the console.
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) // Breathing Activity.
            {
                // Instantiate and run BreathingActivity.
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if (userChoice == 2) // Reflecting Activity.
            {
                // Instantiate and run ReflectingActivity.
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if (userChoice == 3) // Listing Activity.
            {
                // Instantiate and run ListingActivity.
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else if (userChoice == 4) // Quit choice.
            {
                // Display a closing message and exit the program.
                Console.WriteLine("\nThank you for using the program!");
            }

            else
            {
                // Prompt the user to enter a valid option.
                Console.WriteLine("\nEnter a valid option.");
            }
        }
    }
}