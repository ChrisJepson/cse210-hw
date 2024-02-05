public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.Clear();
        Console.WriteLine("Journal Entries:");

        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}, Gratitude: {entry.Gratitude}");
        }

        Console.WriteLine();
    }

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public void SetEntries(List<Entry> newEntries)
    {
        entries = newEntries;
    }
}