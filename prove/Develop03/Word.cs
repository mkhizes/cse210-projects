using System.Reflection.Metadata;
using System;
public class Word

    {
    private string text;

    public Word(string text)
    {
        this.text = text;
    }

    public string GetText()
    {
        return text;
    }

    public void Hide()
    {
        text = "______"; // Replace the word with underscores to hide it
    }

}