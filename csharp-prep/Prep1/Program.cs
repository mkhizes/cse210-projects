using System;

class Program
{
    static void Main(string[] args)
    { //Ask for their name
                 
        
        Console.Write("What is your name?  ");
        string firstName = Console.ReadLine();
        

        Console.Write("What is your last name?  ");
        string lastName = Console.ReadLine();
        

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");

        Console.Write("Enter Percentage you obtained? ");
        string UserValue= Console.ReadLine();
        int x = int.Parse(UserValue);

        if (x>=90)
        {
            Console.Write(" Congratulation you got A");
        }
        else if (x>=80)
        {
            Console.Write("Congratulation you got B");
        }
        else if(x>=70)
        {
            Console.Write("Congratulation you got C");
        }
        else if(x<70)
        {
            Console.Write("Sorry, put more effort next time ");
        }
        
    }
}