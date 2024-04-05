class Running : Activity
{
    private double _distance;

    public Running(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override string GetDistance()
    {
        return $"{_distance} miles";
    }

    public override string GetSpeed()
    {
        return $"{(_distance / _duration) * 60:F1} mph";
    }

    public override string GetPace()
    {
        return $"{_duration / _distance:F2} min per mile";
    }

    protected override string _GetActivityType()
    {
        return "Running";
    }
}