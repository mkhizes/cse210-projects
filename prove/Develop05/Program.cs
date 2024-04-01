using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        // Load existing goals and scores
        List<Goal> goals = LoadGoals();
        int score = LoadScore();

        // Main menu loop
        while (true)
        {
            Console.WriteLine("\nEternal Quest - Main Menu");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewGoals(goals);
                    break;
                case "2":
                    CreateGoal(goals);
                    break;
                case "3":
                    RecordEvent(goals, ref score);
                    break;
                case "4":
                    Console.WriteLine($"Your current score is: {score}");
                    break;
                case "5":
                    SaveGoals(goals);
                    SaveScore(score);
                    Console.WriteLine("Thank you for playing Eternal Quest!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }

    static void ViewGoals(List<Goal> goals)
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in goals)
        {
            Console.Write($"- {goal.Name} [{(goal.IsComplete ? "X" : " ")}]");

            if (goal.Type == GoalType.Checklist)
            {
                Console.WriteLine($" (Completed {goal.TimesCompleted}/{goal.TargetTimes} times)");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    static void CreateGoal(List<Goal> goals)
    {
        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Enter your choice: ");
        string typeChoice = Console.ReadLine();

        GoalType type;
        switch (typeChoice)
        {
            case "1":
                type = GoalType.Simple;
                break;
            case "2":
                type = GoalType.Eternal;
                break;
            case "3":
                type = GoalType.Checklist;
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Simple goal.");
                type = GoalType.Simple;
                break;
        }

        int targetTimes = 0;
        if (type == GoalType.Checklist)
        {
            Console.Write("Enter the target number of times to complete the goal: ");
            targetTimes = int.Parse(Console.ReadLine());
        }

        goals.Add(new Goal { Name = name, Type = type, TargetTimes = targetTimes });
        Console.WriteLine("Goal created successfully!");
    }

    static void RecordEvent(List<Goal> goals, ref int score)
    {
        Console.WriteLine("Select the goal you accomplished:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter the number corresponding to your goal: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex < 0 || goalIndex >= goals.Count)
        {
            Console.WriteLine("Invalid goal selection.");
            return;
        }

        Goal goal = goals[goalIndex];
        switch (goal.Type)
        {
            case GoalType.Simple:
                score += 1000; // Arbitrary score for simple goals
                Console.WriteLine($"You gained 1000 points for completing {goal.Name}!");
                goal.IsComplete = true;
                break;
            case GoalType.Eternal:
                score += 100; // Arbitrary score for eternal goals
                Console.WriteLine($"You gained 100 points for completing {goal.Name}!");
                break;
            case GoalType.Checklist:
                score += 50; // Arbitrary score for each checklist completion
                goal.TimesCompleted++;

                if (goal.TimesCompleted >= goal.TargetTimes)
                {
                    score += 500; // Bonus for completing checklist
                    Console.WriteLine($"You gained 500 bonus points for completing {goal.Name}!");
                    goal.IsComplete = true;
                }
                else
                {
                    Console.WriteLine($"You gained 50 points for completing {goal.Name}!");
                }
                break;
            default:
                break;
        }
    }

    static List<Goal> LoadGoals()
    {
        List<Goal> goals = new List<Goal>();
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    goals.Add(new Goal
                    {
                        Name = parts[0],
                        Type = (GoalType)Enum.Parse(typeof(GoalType), parts[1]),
                        IsComplete = bool.Parse(parts[2]),
                        TargetTimes = int.Parse(parts[3]),
                        TimesCompleted = int.Parse(parts[4])
                    });
                }
            }
        }
        return goals;
    }

    static void SaveGoals(List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Type},{goal.IsComplete},{goal.TargetTimes},{goal.TimesCompleted}");
            }
        }
    }

    static int LoadScore()
    {
        if (File.Exists("score.txt"))
        {
            return int.Parse(File.ReadAllText("score.txt"));
        }
        return 0;
    }

    static void SaveScore(int score)
    {
        File.WriteAllText("score.txt", score.ToString());
    }
}

enum GoalType
{
    Simple,
    Eternal,
    Checklist
}