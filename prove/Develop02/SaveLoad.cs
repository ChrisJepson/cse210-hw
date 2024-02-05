using System.IO;

public class SaveLoad
{
    public static void SaveJournalToFile(List<Entry> entries, string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving the journal: {ex.Message}\n");
        }
    }

    public static List<Entry> LoadJournalFromFile(string fileName)
    {
        List<Entry> loadedEntries = new List<Entry>();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        Entry entry = new Entry
                        {
                            Date = date,
                            Prompt = parts[1],
                            Response = parts[2]
                        };
                        loadedEntries.Add(entry);
                    }
                }
            }

            Console.WriteLine("Journal loaded successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading the journal: {ex.Message}\n");
        }

        return loadedEntries;
    }
}