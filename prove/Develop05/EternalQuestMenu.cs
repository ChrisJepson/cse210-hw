public class EternalQuestMenu
    {
        private List<Goal> goals = new List<Goal>();
        public int TotalPoints { get; private set; }

        public void DisplayMenu()
        {
            Console.WriteLine("Eternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
        }

        public void CreateGoal()
        {
            Console.WriteLine("Choose Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goals.Add(CreateSimpleGoal());
                    break;
                case "2":
                    goals.Add(CreateEternalGoal());
                    break;
                case "3":
                    goals.Add(CreateChecklistGoal());
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }

        private Goal CreateSimpleGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter short description: ");
            string description = Console.ReadLine();
            Console.Write("Enter point value: ");
            int points = int.Parse(Console.ReadLine());
            return new SimpleGoal(name, description, points);
        }

        private Goal CreateEternalGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter short description: ");
            string description = Console.ReadLine();
            Console.Write("Enter point value: ");
            int points = int.Parse(Console.ReadLine());
            return new EternalGoal(name, description, points);
        }

        private Goal CreateChecklistGoal()
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter short description: ");
            string description = Console.ReadLine();
            Console.Write("Enter point value: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Enter total completions needed: ");
            int totalCompletions = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for total completion: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            return new ChecklistGoal(name, description, points, totalCompletions, bonusPoints);
        }

        public void ListGoals()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in goals)
            {
                Console.WriteLine(goal);
            }
        }

        public void SaveGoals()
        {
            Console.Write("Enter the file name to save the goals: ");
            string fileName = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine($"Total Points: {TotalPoints}");
                foreach (var goal in goals)
                {
                    writer.WriteLine(goal.ToFileFormat());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }

        public void LoadGoals()
        {
            Console.Write("Enter the file name to load the goals: ");
            string fileName = Console.ReadLine();
            goals.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                bool firstLine = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        TotalPoints = int.Parse(line.Split(':')[1].Trim());
                        firstLine = false;
                    }
                    else
                    {
                        goals.Add(Goal.FromFileFormat(line));
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }

        public void RecordEvent()
{
    Console.WriteLine("Select Goal to Record Event:");
    for (int i = 0; i < goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {goals[i]}");
    }
    Console.Write("Enter your choice: ");
    int choice = int.Parse(Console.ReadLine()) - 1;

    if (choice >= 0 && choice < goals.Count)
    {
        Goal goal = goals[choice];
        goal.RecordCompletion();
        TotalPoints += goal.GetPoints();

        if (goal is ChecklistGoal checklistGoal)
        {
            if (!checklistGoal.Completed)
            {
                checklistGoal.CurrentCompletions++;
                if (checklistGoal.CurrentCompletions == checklistGoal.TotalCompletions)
                {
                    checklistGoal.RecordCompletion();
                    TotalPoints += checklistGoal.BonusPoints;
                }
            }
        }

        Console.WriteLine("Event recorded successfully.");
    }
    else
    {
        Console.WriteLine("Invalid choice. Please enter a valid option.");
    }
}
    }