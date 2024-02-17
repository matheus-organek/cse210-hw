public abstract class Activity
{
    private int _duration;

    public Activity(int duration) 
    {
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; }
    }
}
