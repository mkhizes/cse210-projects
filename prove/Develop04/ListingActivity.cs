public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count,List<string> prompts,string ActivityName,string Description,int Duration):base(ActivityName,Description,Duration)
    {
        _count=count;
        _prompts=prompts;
        return;
    }
    public int GetCount()
    {
        return _count;
    }
    public List<string> GetPrompt()
    {
        return _prompts;
    }

}