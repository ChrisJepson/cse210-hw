using System;

public class PromptGenerator{

    public static string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is a new skill or hobby I want to explore?",
        "Describe a moment that made me laugh today.",
        "What is a goal I want to accomplish this week?",
        "What book, movie, or song had an impact on me recently?",
        "Reflect on a challenge I faced today and how I overcame it.",
        "What is a personal achievement I'm proud of?"
    };

    public static string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(prompts.Length);
        return prompts[randomIndex];
    }
}