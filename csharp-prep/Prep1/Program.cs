using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("What is your first name?");
        string firstname=Console.Readline(firstname);

        Console.WriteLine(" What is your last name?");
        string lastname=Console.Readline();

        Console.WriteLine($"Your name is {lastname},{firstname} + {lastname}");
    }
}