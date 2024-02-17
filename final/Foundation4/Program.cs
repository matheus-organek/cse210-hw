using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store activities.
        List<Activity> activities = new List<Activity>();

        // Add at least one activity of each type to the list.
        activities.Add(new Running(30, 4.8));
        activities.Add(new Bicycle(45, 20));
        activities.Add(new Swimming(60, 20)); // Considering 20 laps for demonstration.

        // Cleans the Console.
        Console.Clear();

        // Iterate through the list and call GetSummary() on each item.
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.ReadLine(); // Wait for user input before closing the window.
    }
}