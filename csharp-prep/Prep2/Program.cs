using System;

class Program
{
    static void Main(string[] args)
    {
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