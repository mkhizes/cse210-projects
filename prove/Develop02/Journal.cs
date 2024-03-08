using System.IO;
using System;
using System.Collections.Generic;
public class Journal
{
    public List<Entry>_entries;
     // Create a list
List<Entry> entriesList = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        entriesList.Add(newEntry); 
    }
    public void DisplayAll()
    {
        Console.WriteLine(_entries);
    }
    public void SaveToFile(string file)
    {
Console.WriteLine("Saving to file...");
            
    }
    public void LoadFromFile(string file)
    {
        return;
    }
}