public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(int chapter, int startVerse)
    {
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = startVerse;
    }

    public Reference(int chapter, int startVerse, int endVerse)
    {
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book}-{_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}