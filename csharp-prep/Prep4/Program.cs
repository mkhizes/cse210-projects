using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput;
        do
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out userInput))
            {
                if (userInput != 0)
                {
                    numbers.Add(userInput);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (userInput != 0);

        if (numbers.Count > 0)
        {
            int sum = 0;
            int largestNumber = int.MinValue;

            foreach (int number in numbers)
            {
                sum += number;

                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largestNumber}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }

        Console.ReadLine(); // Keep the console window open
    
    }
    
}