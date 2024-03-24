using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string _name, string _description, int _duration)
    {
        
        return;
    }
    
    public string GetActivityName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        return;
    }
    public void DisplayEndingMessage()
    {
        return;
    }
    public void ShowSpinner(int seconds)
    {
        return;
    }
    public void CountDown(int seconds)
    {
        return;
    }
    
}