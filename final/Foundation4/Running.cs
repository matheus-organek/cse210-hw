public class Running : Activity
{
    private double _distance;

    public Running(int duration, double distance) : base(duration) 
    {
        _distance = distance;
    }

    public override double GetDistance() 
    {
        return _distance;
    }

    public override double GetSpeed() 
    {
        // Assuming speed = distance / duration in hours
        double hours = (double)Duration / 60; // Convert duration to hours
        return _distance / hours;
    }

    public override double GetPace() 
    {
        // Assuming pace = duration / distance in minutes per mile
        return (double)Duration / _distance;
    }

    public override string GetSummary() 
    {
        return $"{DateTime.Now.ToShortDateString()} Running ({Duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}
