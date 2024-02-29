using System;

class Program
{
    static void Main(string[] args)
    { //Ask for their name
        Console.Write("What is your name?");
        string firstname = "Scott";
        Console.WriteLine(firstname);

        Console.Write("What is your last name?");
        string lastname = "Burton";
        Console.WriteLine(lastname);

        Console.WriteLine($"Your name is Burton,{firstname} {lastname} ");
    
        
        Console.Write("What is your name?  ");
        string firstName = Console.ReadLine();
        

        Console.Write("What is your last name?  ");
        string lastName = Console.ReadLine();
        

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");
    }
}