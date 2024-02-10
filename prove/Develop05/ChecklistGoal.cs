public class ChecklistGoal : Goal
{
    // Attributes specific to ChecklistGoal
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0; // Initialize amountCompleted to 0
        _target = target;
        _bonus = bonus;
    }

    // Method to record an event for a checklist goal
    public override void RecordEvent()
    {
        // Increment the amountCompleted when recording an event
        _amountCompleted++;
    }

    // Method to check if the checklist goal is complete
    public override bool IsComplete()
    {
        // Check if the amountCompleted matches the target
        return _amountCompleted >= _target;
    }

    // Method to get a detailed string representation of the checklist goal
    public override string GetDetailsString()
    {
        // Return detailed information about the checklist goal
        return $"{_shortName} - {_description} - Completed {_amountCompleted}/{_target} times";
    }

    // Method to get a string representation of the checklist goal
    public override string GetStringRepresentation()
    {
        // Return a string representation of the goal
        return $"Checklist Goal: {_shortName} - {_description} - {_points} points - {_amountCompleted}/{_target} completed - Bonus: {_bonus}";
    }
}