using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name?");
        string firstname = "Scott";
        Console.WriteLine(firstname);

        Console.Write("What is your last name?");
        string lastname = "Burton";
        Console.WriteLine(lastname);

        Console.WriteLine($"Your name is Burton,{firstname} {lastname} ");
    
        
        Console.Write("What is your name?");
        string first_name = Console.ReadLine();
        

        Console.Write("What is your last name?");
        string last_name = Console.ReadLine();
        

        Console.WriteLine($"Your name is {last_name},{first_name} {last_name}. ");
    }
}