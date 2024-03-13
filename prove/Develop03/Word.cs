using System.Reflection.Metadata;
using System;
public class Word

    {
    private string _text;

    public Word(string text)
    {
        this._text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public void Hide()
    {
        _text = "______"; // Replace the word with underscores to hide it
    }

}