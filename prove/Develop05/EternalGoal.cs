public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional attributes specific to EternalGoal
    }

    // Method to record an event for an eternal goal
    public override void RecordEvent()
    {
        // Implementation specific to EternalGoal
        // No need to record events for eternal goals
    }

    // Method to check if the eternal goal is complete
    public override bool IsComplete()
    {
        // Implementation specific to EternalGoal
        // Eternal goals are never complete
        return false;
    }

    // Method to get a string representation of the eternal goal
    public override string GetStringRepresentation()
    {
        // Implementation specific to EternalGoal
        // Return a string representation of the goal
        return $"Eternal Goal: {_shortName} - {_description} - {_points} points";
    }
}