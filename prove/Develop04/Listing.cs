using System;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration, "Listing Activity") { }

    public override void Start()
    {
        Console.WriteLine(ActivityName);
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Thread.Sleep(3000);

        Console.WriteLine("Prepare to begin...");
        PauseFunction();

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"You have {duration} seconds to list as many items as you can.");

        PauseFunction();

        int itemsCount = 0;

        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                itemsCount++;
        }

        Console.WriteLine($"You have listed {itemsCount} items.");
        Thread.Sleep(2000);

        DisplayEndingMessage();
    }
}
