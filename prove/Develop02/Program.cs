using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static List<Entry> journal = new List<Entry>();

    static void Main(string[] args)
    {
        LoadJournal();

        while (true)
        {
            DisplayMenu();
            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;

                case 2:
                    DisplayJournal();
                    break;

                case 3:
                    SaveJournalToFile();
                    break;

                case 4:
                    LoadJournalFromFile();
                    break;

                case 5:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Journal Program Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
    }

    static int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return choice;
    }

    static void WriteNewEntry()
    {
        Console.WriteLine("Writing a new entry...");

        Console.WriteLine("Choose a prompt from the list:");
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        for (int i = 0; i < prompts.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        int promptIndex = GetUserChoice() - 1;
        if (promptIndex >= 0 && promptIndex < prompts.Length)
        {
            Console.WriteLine($"Enter your response to the prompt: '{prompts[promptIndex]}'");
            string response = Console.ReadLine();
            journal.Add(new Entry(prompts[promptIndex], response, DateTime.Now));
            Console.WriteLine("Entry added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid prompt selection.");
        }
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");

        foreach (var entry in journal)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
        }
    }

    static void SaveJournalToFile()
    {
        Console.WriteLine("Enter a filename to save the journal:");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved to file successfully.");
    }

    static void LoadJournalFromFile()
    {
        Console.WriteLine("Enter the filename to load the journal:");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            journal.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        DateTime date;
                        if (DateTime.TryParse(parts[0], out date))
                        {
                            journal.Add(new Entry(parts[1], parts[2], date));
                        }
                    }
                }
            }

            Console.WriteLine("Journal loaded from file successfully.");
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    static void LoadJournal()
    {
        if (File.Exists("journal.txt"))
        {
            LoadJournalFromFile();
        }
    }
}
