using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Del Taco";
        job1._jobTitle = "Manager";
        job1._startyear = 1706;
        job1._endyear = 2020;
        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Manager";
        job2._startyear = 2020;
        job2._endyear = 2024;

        Resume r = new Resume();
        r._name = "Christopher Jepson";
        r._jobs.Add(job1);
        r._jobs.Add(job2);
        r.Display();

    }
}