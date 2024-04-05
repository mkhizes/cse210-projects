using System;
using System.Collections.Generic;
using System.IO;
class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {_GetEventType()}\nTitle: {_title}\nDate: {_date}";
    }

    protected virtual string _GetEventType()
    {
        return "Event";
    }
}