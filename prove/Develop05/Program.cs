using System;

class Program
{
    static void Main(string[] args)
    {
        EternalQuestMenu menu = new EternalQuestMenu();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine($"Total Points: {menu.TotalPoints}");
                menu.DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        menu.CreateGoal();
                        break;
                    case "2":
                        menu.ListGoals();
                        break;
                    case "3":
                        menu.SaveGoals();
                        break;
                    case "4":
                        menu.LoadGoals();
                        break;
                    case "5":
                        menu.RecordEvent();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
}