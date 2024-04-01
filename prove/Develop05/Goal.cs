using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Goal
{
    public string Name { get; set; }
    public GoalType Type { get; set; }
    public bool IsComplete { get; set; }
    public int TargetTimes { get; set; }
    public int TimesCompleted { get; set; }
}