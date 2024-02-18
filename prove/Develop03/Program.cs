using System;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new Scripture[]
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5), "Trust in the Lord with all your heart and lean not on your own understanding;"),
            new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."),
            new Scripture(new Reference("2 Nephi", 10, 24), "Wherefore, my beloved brethren, reconcile yourselves to the will of God, and not to the will of the devil and the flesh; and remember, after ye are reconciled unto God, that it is only in and through the grace of God that ye are saved.")
        };

        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        // Randomly select the first scripture
        var random = new Random();
        var selectedScripture = GetRandomScripture(scriptures);
        DisplayScripture(selectedScripture);

        while (true)
        {
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            selectedScripture.HideRandomWords();
            Console.Clear();
            DisplayScripture(selectedScripture);

            if (selectedScripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Memorization complete!");

                // Randomly select a new scripture
                selectedScripture = GetRandomScripture(scriptures);
                Console.WriteLine("Next scripture:");
                DisplayScripture(selectedScripture);
            }
            else
            {
                Console.WriteLine("Keep practicing or type 'quit' to exit.");
            }
        }
    }

    static Scripture GetRandomScripture(Scripture[] scriptures)
    {
        var random = new Random();
        var scriptureIndex = random.Next(scriptures.Length);
        return scriptures[scriptureIndex];
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine($"Scripture Reference: {scripture.Reference.Book} {scripture.Reference.Chapter}:{scripture.Reference.Verse}");
        Console.WriteLine($"Scripture Text: {scripture.CheckIfHidden()}");
    }
}
