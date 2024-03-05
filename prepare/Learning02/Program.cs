using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    { 
       Job job1=new Job();
       job1._company="Microsoft";
       job1._jobtitle="Software Developer";
       job1._start_year=2003;
       job1._end_year=2014;

        Job job2=new Job();
       job2._company="Microsoft";
       job2._jobtitle="Software Engineer";
       job2._start_year=2020;
       job2._end_year=2024;

    Resume myResume= new Resume();
    myResume._name="Sizwe Mkhize";

    myResume.jobs.Add(job1);
    myResume.jobs.Add(job2);
    
    
    myResume.Display();
    
    }
}