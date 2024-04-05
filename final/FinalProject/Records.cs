// Records class for saving rental details to a file
public class Records
{
    public void SaveRentalRecord(string record)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("rental_records.txt", true))
            {
                writer.WriteLine(record);
            }
            Console.WriteLine("Rental record saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while saving rental record: {ex.Message}");
        }
    }
}