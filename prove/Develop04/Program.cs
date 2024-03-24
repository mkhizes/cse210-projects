using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Please choose an activity (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity();
                    break;
                case "2":
                    ReflectingActivity(new List<string>(), new List<string>());
                    break;
                case "3":
                    ListingActivity(0, new List<string>());
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the Activity Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid activity.");
                    break;
            }
        }
    }

    static void PauseWithSpinner(int seconds)
    {
        Console.WriteLine("Pausing for a moment...");
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(". ");
        }
        Console.WriteLine();
    }

    static void BreathingActivity()
    {
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.Write("Please enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);

        int remainingTime = duration;
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner(2);
            remainingTime -= 2;

            if (remainingTime <= 0)
                break;

            Console.WriteLine("Breathe out...");
            PauseWithSpinner(2);
            remainingTime -= 2;
        }

        Console.WriteLine("Well done! You have completed the Breathing Activity for {0} seconds.", duration);
        PauseWithSpinner(3);
    }

    static void ReflectingActivity(List<string> _prompts, List<string> _questions)
    {
        Console.WriteLine("Welcome to the Reflection Activity!");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("Please enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        Random random = new Random();
        int randomIndex = random.Next(prompts.Length);

        Console.WriteLine(prompts[randomIndex]);

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (var question in questions)
        {
            Console.WriteLine(question);
            PauseWithSpinner(3);
        }

        Console.WriteLine("Well done! You have completed the Reflection Activity for {0} seconds.", duration);
        PauseWithSpinner(3);
    }

    static void ListingActivity(int _count, List<string> prompt)
    {
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("Please enter the duration of the activity in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        int randomIndex = random.Next(prompts.Length);

        Console.WriteLine(prompts[randomIndex]);

        Console.WriteLine("You have {0} seconds to start listing...", duration);
        Thread.Sleep(duration * 1000);

        Console.WriteLine("Time's up!");

        Console.WriteLine("Well done! You have completed the Listing Activity for {0} seconds.", duration);
        PauseWithSpinner(3);
    }
}