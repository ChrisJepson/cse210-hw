using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration, "Breathing Activity") { }

    public override void Start()
    {
        Console.WriteLine(ActivityName);
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Thread.Sleep(3000);

        Console.WriteLine("Prepare to begin...");
        PauseFunction();

         DateTime startTime = DateTime.Now;


        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);
            Console.WriteLine("Breathe out...");
            Countdown(3);
        }

        DisplayEndingMessage();
    }
}
