using System;

class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option (1-5).");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        Console.Clear();
        Console.WriteLine("Write a new entry:");

        string prompt = PromptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        journal.AddEntry(entry);

        Console.WriteLine("Entry added successfully!\n");
    }

    static void DisplayJournal()
    {
        journal.DisplayEntries();
    }

    static void SaveJournalToFile()
    {
        Console.Clear();
        Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        SaveLoad.SaveJournalToFile(journal.GetEntries(), fileName);
    }

    static void LoadJournalFromFile()
    {
        Console.Clear();
        Console.Write("Enter the filename to load the journal: ");
        string fileName = Console.ReadLine();

        List<Entry> loadedEntries = SaveLoad.LoadJournalFromFile(fileName);
        journal.SetEntries(loadedEntries);
    }
}