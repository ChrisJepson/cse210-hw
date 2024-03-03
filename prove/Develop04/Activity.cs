using System;

public abstract class Activity
{
    protected int duration;
    protected string ActivityName;


    public Activity(int duration, string activityName)
    {
        this.duration = duration;
        this.ActivityName = activityName;
    }

    public abstract void Start();

    // Method to display loading animation
    protected void PauseFunction()
    {
    List<string> animationStrings = new List<string>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(5);

    int i = 0;

    while (DateTime.Now < endTime)
    {
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;

        if (i >= animationStrings.Count)
        {
            i = 0;
        }
    }

    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"\rCountdown: {i}    ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\r             ");
    }

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {ActivityName} for {duration} seconds.");

    }
}
