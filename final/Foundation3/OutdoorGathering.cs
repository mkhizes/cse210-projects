class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public override string GetStandardDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: Unknown";
    }

    protected override string _GetEventType()
    {
        return "Outdoor Gathering";
    }
}