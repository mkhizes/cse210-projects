
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class SimpleGoal : Goal
{
    public  int RecordEvent()
    {
        IsComplete = true;
        // Arbitrary score for completing a simple goal
        return 1000;
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
        return $"{Name},SimpleGoal,{IsComplete}";
    }
}