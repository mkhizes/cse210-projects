using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name?");
        string firstname = Console.Read();
        Console.WriteLine(firstname);

        Console.Write("What is your last name?");
        string lastname = Console.Read();
        Console.WriteLine(lastname);

        Console.WriteLine($"Your name is {lastname},{firstname} {lastname} ");
    
        
        Console.Write("What is your name?");
        string first_name = Console.ReadLine();
        Console.WriteLine(first_name);

        Console.Write("What is your last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine(last_name);

        Console.WriteLine($"Your name is {last_name},{first_name} {last_name} ");
    }
}