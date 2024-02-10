public abstract class Goal
{
    // Attributes
    protected string _shortName; // Name of the goal
    protected string _description; // Description of the goal
    protected int _points; // Points associated with the goal

    // Constructor
    // Initializes the attributes of the goal
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Method to record an event for the goal (to be implemented by derived classes)
    public abstract void RecordEvent();

    // Method to check if the goal is complete (to be implemented by derived classes)
    public abstract bool IsComplete();

    // Method to get details of the goal as a string
    // (to be overridden by derived classes if necessary)
    public virtual string GetDetailsString()
    {
        return ""; // Default implementation returns an empty string
    }

    // Method to get a string representation of the goal 
    // (to be implemented by derived classes)
    public abstract string GetStringRepresentation();
}