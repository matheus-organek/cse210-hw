public class Swimming : Activity
{
    private int _laps;

    public Swimming(int duration, int laps) : base(duration) 
    {
        _laps = laps;
    }

    public override double GetDistance() 
    {
        // Assuming each lap is 50 meters
        return _laps * 50.0 / 1000.0; // Convert meters to kilometers
    }

    public override double GetSpeed() 
    {
        // Assuming speed = distance / duration in hours
        double hours = (double)Duration / 60; // Convert duration to hours
        return GetDistance() / hours;
    }

    public override double GetPace() {
        // Assuming pace = duration / distance in minutes per kilometer
        return (double)Duration / GetDistance();
    }

    public override string GetSummary() 
    {
        return $"{DateTime.Now.ToShortDateString()} Swimming ({Duration} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }
}
