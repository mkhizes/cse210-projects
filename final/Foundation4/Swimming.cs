class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override string GetDistance()
    {
        return $"{(_laps * 50) / 1000.0:F1} km";
    }

    public override string GetSpeed()
    {
        return $"{((_laps * 50) / 1000.0 * 0.62) / _duration * 60.0:F1} mph";
    }

    public override string GetPace()
    {
        return $"{_duration / (_laps * 50.0 / 1000.0):F2} min per km";
    }

    protected override string _GetActivityType()
    {
        return "Swimming";
    }
}
