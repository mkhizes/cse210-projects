public class Reference
{
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(int chapter, int startVerse)
    {
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = startVerse;
    }

    public Reference(int chapter, int startVerse, int endVerse)
    {
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    {
        if (startVerse == endVerse)
        {
            return $"{chapter}:{startVerse}";
        }
        else
        {
            return $"{chapter}:{startVerse}-{endVerse}";
        }
    }
}