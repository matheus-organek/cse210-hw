using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Clear the console screen.
        Console.Clear();

        Console.WriteLine($"You have {_score} points.");

        // Initialize userChoice variable to control menu selection.
        int userChoice = 0;

        // Display menu options until the user chooses to quit.
        while (userChoice != 6)
        {
            // Display menu options.
            Console.WriteLine("Menu options:" +
                                "\n   1. Create a New Goal" +
                                "\n   2. List Goals" +
                                "\n   3. Save Goals" +
                                "\n   4. Load Goals" +
                                "\n   5. Record Event" +
                                "\n   6. Quit");

            // Prompt the user to select an option from the menu.
            Console.Write("Select a choice from the menu: ");
            // Read the user's choice from the console.
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Creating a New Goal...");
        // Implement logic to create a new goal
    }

    private void ListGoals()
    {
        Console.WriteLine("Listing Goals...");
        // Implement logic to list goals
    }

    private void SaveGoals()
    {
        Console.WriteLine("Saving Goals...");
        // Implement logic to save goals
    }

    private void LoadGoals()
    {
        Console.WriteLine("Loading Goals...");
        // Implement logic to load goals
    }

    private void RecordEvent()
    {
        Console.WriteLine("Recording Event...");
        // Implement logic to record an event
    }
}