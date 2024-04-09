public class Renter
{
    private int id;
    private string name;
    private string phoneNumber;

    public Renter(int id, string name, string phoneNumber)
    {
        this.id = id;
        this.name = name;
        this.phoneNumber = phoneNumber;
    }

    public int Id => id;

    public string Name => name;

    public string PhoneNumber => phoneNumber;
}
