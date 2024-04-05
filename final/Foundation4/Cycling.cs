class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int duration, int speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override string GetDistance()
    {
        return $"{(_speed * _duration) / 60.0:F1} miles";
    }

    public override string GetSpeed()
    {
        return $"{_speed} mph";
    }

    public override string GetPace()
    {
        return $"{60.0 / _speed:F2} min per mile";
    }

    protected override string _GetActivityType()
    {
        return "Cycling";
    }
}