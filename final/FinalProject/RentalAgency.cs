// RentalAgency.cs

using System.Collections.Generic;

public class RentalAgency
{
    private List<Vehicle> vehicles;
    private List<Renter> renters;

    public RentalAgency()
    {
        this.vehicles = new List<Vehicle>();
        this.renters = new List<Renter>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        vehicles.Remove(vehicle);
    }

    public List<Vehicle> GetAvailableVehicles()
    {
        return vehicles;
    }

    public float RentVehicle(Vehicle vehicle, int days, Renter renter)
    {
        return vehicle.Rent(days, renter);
    }

    public void AddRenter(Renter renter)
    {
        renters.Add(renter);
    }

    public void RemoveRenter(Renter renter)
    {
        renters.Remove(renter);
    }
}
