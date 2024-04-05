// Car.cs

public class Car : Vehicle
{
    private int numSeats;

    public Car(string model, int year, float rentalPricePerDay, int numSeats) : base(model, year, rentalPricePerDay)
    {
        this.numSeats = numSeats;
    }

    public int NumSeats => numSeats;

    public override float Rent(int days, Renter renter)
    {
        // Calculate rental price for car based on days rented
        // Return the total rental price
        return days * RentalPricePerDay;
    }
}
