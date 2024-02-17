public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(int duration, double speed) : base(duration) 
    {
        _speed = speed;
    }

    public override double GetDistance() 
    {
        // Assuming distance = speed * duration
        return _speed * (Duration / 60.0); // Convert duration to hours
    }

    public override double GetSpeed() 
    {
        return _speed;
    }

    public override double GetPace() 
    {
        // Assuming pace = 60 / speed in minutes per mile
        return 60.0 / _speed;
    }

    public override string GetSummary() 
    {
     return $"{DateTime.Now.ToShortDateString()} Bicycle ({Duration} min) - Distance: {GetDistance()} km, Speed: {_speed} km/h, Pace: {GetPace()} min per km";
    }
}
