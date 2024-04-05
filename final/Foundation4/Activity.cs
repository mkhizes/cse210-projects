using System;

class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string GetDistance()
    {
        return "";
    }

    public virtual string GetSpeed()
    {
        return "";
    }

    public virtual string GetPace()
    {
        return "";
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_GetActivityType()} ({_duration} min) - Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }

    protected virtual string _GetActivityType()
    {
        return "Activity";
    }
}
