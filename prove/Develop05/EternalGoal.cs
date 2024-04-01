using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class EternalGoal : Goal
{
    public  int RecordEvent()
    {
        // For eternal goal, just mark it as complete
        IsComplete = true;
        // Arbitrary score for recording an event for an eternal goal
        return 100;
    }

    public  bool IsGoalComplete()
    {
        return IsComplete;
    }

    public  string GetDetailsString()
    {
        return $"[ ] {Name}";
    }

    public  string GetStringRepresentation()
    {
        return $"{Name},EternalGoal,{IsComplete}";
    }
}