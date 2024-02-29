using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Percentage you obtained? ");
        string UserValue= Console.ReadLine();
        int x = int.Parse(UserValue);
        string letter=" ";
        
        if (x>=90)
        {
            letter ="A";
        }
        else if (x>=80)
        {
            letter="B";
        }
        else if(x>=70)
        {
            letter="C";
        }
        else if(x>=60)
        {
            letter="D";
        }
        else if(x>=50)
        {
            letter="E";
        }
        else
        {
            letter="F";
        }
        Console.Write($"Your Grade is:{letter} ");
        if (x>=70)
        {
            Console.WriteLine("You have Passed");
        }
        else
        {
            Console.WriteLine("Better Luck Next Time!");
        }
    }
}