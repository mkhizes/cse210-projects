using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    

    { 
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select one of the following choices  ");
               
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.WriteLine("What would you like to do?  ");
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
          Console.WriteLine("entries.txt");  
        }
        else if(choice==4)
        {
            Console.WriteLine("entries.txt");
        }
        else if(choice==5)
        {
            Console.WriteLine("Thank you, GoodBye!!!");
        }

        Entry e1= new Entry();
        e1._date="11/02/2020";
        e1._promptText="Who was the most interesting person I interacted with today?";
        e1._entryText="Journal entry";

        Entry e2= new Entry();
        e2._date="10/02/2020";
        e2._promptText="What was the best part of my day?";
        e2._entryText="";


        Entry e3= new Entry();
        e3._date="09/03/2024";
        e3._promptText="How did I see the hand of the Lord in my life today?";
        e3._entryText="The way things has been through out this day,which signifies the blessings and the Lord's existence in my life";

        Entry e4= new Entry();
        e4._date="08/03/2024";
        e4._promptText="What was the strongest emotion I felt today?";
        e4._entryText="I felt Joyous and rejuvenated";

        Entry e5= new Entry();
        e5._date="07/03/2024";
        e5._promptText="If I had one thing I could do over today, what would it be?";
        e5._entryText="Listen to the Holy Spirit as He prompts me";

        Entry e6= new Entry();
        e6._date="12/03/2024";
        e6._promptText="What was the overall life experience and lesson I learned today?";
        e6._entryText=" Great Spiritual experience and the lesson being obedience";

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
             Console.WriteLine("Saving to file...now!!!!!!!!!!!!...........");
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
    
