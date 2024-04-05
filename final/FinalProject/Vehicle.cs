// Vehicle.cs

public abstract class Vehicle
{
    private string model;
    private int year;
    private float rentalPricePerDay;

    public Vehicle(string model, int year, float rentalPricePerDay)
    {
        this.model = model;
        this.year = year;
        this.rentalPricePerDay = rentalPricePerDay;
    }

    public string Model => model;

    public int Year => year;

    public float RentalPricePerDay => rentalPricePerDay;

    public abstract float Rent(int days, Renter renter);
}
