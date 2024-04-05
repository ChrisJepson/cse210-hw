public abstract class Goal
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int Points { get; protected set; }
        public bool Completed { get; protected set; }

        public Goal(string name, string description, int points)
        {
            Name = name;
            Description = description;
            Points = points;
            Completed = false;
        }

        public virtual void RecordCompletion()
        {
            Completed = true;
        }

        public override string ToString()
        {
            return $"{(Completed ? "[X]" : "[ ]")} {Name}";
        }

        public virtual string ToFileFormat()
        {
            return $"{(Completed ? "1" : "0")}:{Name}:{Description}:{Points}";
        }

        public static Goal FromFileFormat(string line)
        {
            string[] parts = line.Split(':');
            bool completed = parts[0] == "1";
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            if (completed)
                return new SimpleGoal(name, description, points);
            else
                return new ChecklistGoal(name, description, points, 0, 0);
        }

        public abstract int GetPoints();
    }

    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override int GetPoints()
        {
            return Completed ? Points : 0;
        }
    }

    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
        }

        public override int GetPoints()
        {
            return Completed ? Points : 0;
        }
    }

    public class ChecklistGoal : Goal
    {
        public int TotalCompletions { get; private set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, string description, int points, int totalCompletions, int bonusPoints) : base(name, description, points)
        {
            TotalCompletions = totalCompletions;
            BonusPoints = bonusPoints;
        }

        public override void RecordCompletion()
        {
            base.RecordCompletion();
            TotalCompletions++;
            if (TotalCompletions == TotalCompletions)
            {
                Completed = true;
                Points += BonusPoints;
            }
        }

        public override int GetPoints()
        {
            return Completed ? Points : 0;
        }

        public override string ToFileFormat()
        {
            return $"{(Completed ? "1" : "0")}:{Name}:{Description}:{Points}:{TotalCompletions}:{BonusPoints}";
        }

        public new static Goal FromFileFormat(string line)
        {
            string[] parts = line.Split(':');
            bool completed = parts[0] == "1";
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            int totalCompletions = int.Parse(parts[4]);
            int bonusPoints = int.Parse(parts[5]);
            return new ChecklistGoal(name, description, points, totalCompletions, bonusPoints);
        }
    }