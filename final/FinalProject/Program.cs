using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueRenting = true;

        while (continueRenting)
        {
        // Prompt the user to enter customer information
        Console.WriteLine("Enter your information:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();

        // Create a renter with the entered information
        Renter renter = new Renter(1, name, phoneNumber);

        // Create lists to store vehicles of each type
        List<Vehicle> cars = new List<Vehicle>();
        List<Vehicle> motorcycles = new List<Vehicle>();
        List<Vehicle> trucks = new List<Vehicle>();

        cars.Add(new Car("Toyota", 2020, 50.0f, 4));
        cars.Add(new Car("Honda", 2019, 45.0f, 5));
        cars.Add(new Car("Ford", 2018, 55.0f, 4));
        cars.Add(new Car("Chevrolet", 2017, 60.0f, 5));

        motorcycles.Add(new Motorcycle("Harley Davidson", 2019, 30.0f, 1000));
        motorcycles.Add(new Motorcycle("Yamaha", 2021, 35.0f, 750));
        motorcycles.Add(new Motorcycle("Kawasaki", 2020, 32.0f, 800));
        motorcycles.Add(new Motorcycle("Ducati", 2018, 40.0f, 900));

        trucks.Add(new Truck("Ford", 2018, 100.0f, 5000.0f));
        trucks.Add(new Truck("Chevrolet", 2020, 120.0f, 6000.0f));
        trucks.Add(new Truck("GMC", 2019, 110.0f, 5500.0f));
        trucks.Add(new Truck("Dodge", 2017, 105.0f, 4800.0f));

        // Display vehicle options to the user
        Console.WriteLine("Select a vehicle type:");
        Console.WriteLine("1. Car");
        Console.WriteLine("2. Motorcycle");
        Console.WriteLine("3. Truck");
        Console.Write("Enter your choice (1, 2, or 3): ");
        int vehicleTypeChoice = Convert.ToInt32(Console.ReadLine());

        // Select the vehicle type based on user choice
        List<Vehicle> selectedVehicleType = null;
        switch (vehicleTypeChoice)
        {
            case 1:
                selectedVehicleType = cars;
                break;
            case 2:
                selectedVehicleType = motorcycles;
                break;
            case 3:
                selectedVehicleType = trucks;
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
        }

        // Display vehicle options of the selected type to the user
        Console.WriteLine("Select a vehicle:");
        for (int i = 0; i < selectedVehicleType.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {selectedVehicleType[i].Model} - {selectedVehicleType[i].Year}");
        }
        Console.Write("Enter your choice (1, 2, 3 or 4): ");
        int vehicleChoice = Convert.ToInt32(Console.ReadLine());

        // Select the vehicle based on user choice
        Vehicle selectedVehicle = selectedVehicleType[vehicleChoice - 1];

        // Prompt the user to enter rental duration
        Console.Write("Enter the number of rental days: ");
        int rentalDays = Convert.ToInt32(Console.ReadLine());

        // Calculate the rental price
        RentalAgency agency = new RentalAgency();
        float rentalPrice = agency.RentVehicle(selectedVehicle, rentalDays, renter);

        // Calculate tax (assuming 8% tax rate)
        float taxRate = 0.08f;
        float tax = rentalPrice * taxRate;

        // Calculate total (subtotal + tax)
        float total = rentalPrice + tax;

        // Display rental details to the user
        Console.WriteLine($"Subtotal: {rentalPrice:C}");
        Console.WriteLine($"Tax (8%): {tax:C}");
        Console.WriteLine($"Total: {total:C}");

        // Save rental record to file
        Records records = new Records();
        string record = $"{DateTime.Now}: {renter.Name}, {selectedVehicle.Model}, {rentalDays} days, Total: {total:C}";
        records.SaveRentalRecord(record);

         // Ask if there is another renter
        Console.Write("Do you want to rent another vehicle? (yes/no): ");
        string answer = Console.ReadLine();
        if (answer.ToLower() != "yes")
            {
                continueRenting = false;
            }
        }
    }
}