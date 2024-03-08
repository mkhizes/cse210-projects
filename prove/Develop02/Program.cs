//using System;

//class Program
//{
    //static void Main(string[] args)
   // {
       // Console.WriteLine("Hello Develop02 World!");
using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    

    { 
        Console.WriteLine("Welcome to the Journal Program");
        Console.Write("Please select one of the following choices  ");
               
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do?  ");
        int choice=Console.Read();

       if (choice==1)
       {
        string userinput=Console.ReadLine();
        // You can add text to the file with the WriteLine method
        
       }
        else if(choice==2)
        {
            Console.WriteLine("entries.txt");
        }
        else if(choice==3)
        {
            
        }
        else if(choice==4)
        {
            Console.WriteLine("Saving to file....");
        }
        else 
        {
            Console.WriteLine(" You have not made selection!Thank you, GoodBye!!!");
        }

        Entry e1= new Entry();
        e1._date="11/02/2024";
        e1._promptText="Who was the most interesting person I interacted with today?";
        e1._entryText="Journal entry";

        Entry e2= new Entry();
        e2._date="10/02/2024";
        e2._promptText="What was the best part of my day?";
        e2._entryText="";


        Entry e3= new Entry();
        e3._date="09/02/2024";
        e3._promptText="How did I see the hand of the Lord in my life today?";
        e3._entryText="";

        Entry e4= new Entry();
        e4._date="08/02/2024";
        e4._promptText="What was the strongest emotion I felt today?";
        e4._entryText="";

        Entry e5= new Entry();
        e5._date="07/02/2024";
        e5._promptText="If I had one thing I could do over today, what would it be?";
        e5._entryText="";

        Entry e6= new Entry();
        e6._date="08/02/2023";
        e6._promptText="What was the overall life experience and lesson I learned today?";
        e6._entryText="";

         List<Entry> entries=new List<Entry>();
         entries.Add(e1);
         entries.Add(e2);
         entries.Add(e3);
         entries.Add(e4);
         entries.Add(e5);
         entries.Add(e6);

         foreach (Entry e in entries)
         {
 Console.WriteLine(e._promptText);
         }
         SaveToFile(entries);
     }
         public static void SaveToFile( List<Entry> entries)
         {
             Console.WriteLine("Saving to file...");
             string filename="entries.txt";

             using (StreamWriter outputFile=new StreamWriter(filename))
             {
                 //writting entry data into the entries.txt  file 
                 foreach(Entry d in entries)
                {
                    outputFile.WriteLine($"{d._date},{d._promptText},{d._entryText}");
                }
             }
        }
}
    
