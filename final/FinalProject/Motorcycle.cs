// Motorcycle.cs

public class Motorcycle : Vehicle
{
    private int engineSize;

    public Motorcycle(string model, int year, float rentalPricePerDay, int engineSize) : base(model, year, rentalPricePerDay)
    {
        this.engineSize = engineSize;
    }

    public int EngineSize => engineSize;

    public override float Rent(int days, Renter renter)
    {
        // Calculate rental price for motorcycle based on days rented
        // Return the total rental price
        return days * RentalPricePerDay;
    }
}
