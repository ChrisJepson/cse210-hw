// Truck.cs

public class Truck : Vehicle
{
    private float cargoCapacity;

    public Truck(string model, int year, float rentalPricePerDay, float cargoCapacity) : base(model, year, rentalPricePerDay)
    {
        this.cargoCapacity = cargoCapacity;
    }

    public float CargoCapacity => cargoCapacity;

    public override float Rent(int days, Renter renter)
    {
        // Calculate rental price for truck based on days rented
        // Return the total rental price
        return days * RentalPricePerDay;
    }
}
