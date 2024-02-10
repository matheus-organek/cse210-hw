public class SimpleGoal : Goal
{
    // Attribute specific to SimpleGoal
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false; // Initialize _isComplete to false
    }

    // Method to record an event for a simple goal
    public override void RecordEvent()
    {
        // Implementation specific to SimpleGoal
        // Mark the goal as complete
        _isComplete = true;
        // Additional logic if needed, like updating user's score
    }

    // Method to check if the simple goal is complete
    public override bool IsComplete()
    {
        // Implementation specific to SimpleGoal
        return _isComplete;
    }

    // Method to get a string representation of the simple goal
    public override string GetStringRepresentation()
    {
        // Implementation specific to SimpleGoal
        // Return a string representation of the goal
        return $"Simple Goal: {_shortName} - {_description} - {_points} points";
    }
}