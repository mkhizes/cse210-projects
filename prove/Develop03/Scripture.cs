using System;
using System.Collections.Generic;
public class Scripture{


    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        this._reference = reference;
        this._words = words;
    }

    public void Display()
    {
        Console.WriteLine($"Scripture Reference: {_reference}");
        Console.WriteLine("Content:");

        foreach (var word in _words)
        {
            Console.Write(word.GetText() + " ");
        }

        Console.WriteLine("\n");
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);

        if (!_words[index].GetText().Equals("______")) // Check if the word is not already hidden
        {
            _words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.GetText().Equals("______"));
    }
}


