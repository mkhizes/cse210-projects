using System;
using System.Collections.Generic;
public class Scripture{


    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, List<Word> words)
    {
        this.reference = reference;
        this.words = words;
    }

    public void Display()
    {
        Console.WriteLine($"Scripture Reference: {reference}");
        Console.WriteLine("Content:");

        foreach (var word in words)
        {
            Console.Write(word.GetText() + " ");
        }

        Console.WriteLine("\n");
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);

        if (!words[index].GetText().Equals("______")) // Check if the word is not already hidden
        {
            words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.GetText().Equals("______"));
    }
}


