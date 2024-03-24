public class ReflectingActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions, string ActivityName, string Description, int Duration):base(ActivityName, Description,Duration)
    {
        _prompts=prompts;
         _questions=questions;
         return;
    }
    public void Run()
    {
        return;
    }
    public string GetRandomPrompt()
    {
        return($"{_prompts}");
    }
    public string GetRandomQuestion()
    {
        return($" {_questions}");
    }
    public void DisplayPrompt()
    {
        return;
    }
    public void DisplayQuestions()
    {
        return;
    }
}