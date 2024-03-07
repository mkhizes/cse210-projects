using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)

    { 
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