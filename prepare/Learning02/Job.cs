public class Job{
    public string _company;
    public string _jobtitle;
    public int _start_year;
    public int _end_year;
    public void Display()
    {
        Console.WriteLine($"{_company},{_jobtitle},{_start_year},{_end_year}");
    }
}
