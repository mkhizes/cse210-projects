using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class ChecklistGoal : Goal
{
    public new int TargetTimes { get; set; }
    public new int TimesCompleted { get; private set; }

    public  int RecordEvent()
    {
        TimesCompleted++;
        if (TimesCompleted >= TargetTimes)
        {
            IsComplete = true;
            // Bonus points for completing all checklist items
            return 500;
        }
        // Arbitrary score for completing a checklist item
        return 50;
    }

    public bool IsGoalComplete()
    {
        return IsComplete;
    }

    public string GetDetailsString()
    {
        return $"[ ] {Name} (Completed {TimesCompleted}/{TargetTimes} times)";
    }

    public  string GetStringRepresentation()
    {
        return $"{Name},ChecklistGoal,{IsComplete},{TargetTimes},{TimesCompleted}";
    }
}