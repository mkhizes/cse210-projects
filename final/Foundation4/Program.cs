using System;

class Program
{
    static void Main(string[] args)
    {
        
         // Create activities
        Activity[] activities = new Activity[]
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 30, 12),
            new Swimming("03 Nov 2022", 30, 20)
        };

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}