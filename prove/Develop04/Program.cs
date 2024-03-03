using System;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("Welcome! Please choose an activity.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit program");

            Console.Write("What would you like to do?");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 4)
                break;

            Console.Write("Enter duration in seconds: ");
            int duration = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity(duration);
                    breathingActivity.Start();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity(duration);
                    reflectionActivity.Start();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity(duration);
                    listingActivity.Start();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
            }