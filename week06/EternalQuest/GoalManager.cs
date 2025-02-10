class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            // Show completion status for each goal type
            if (goal is SimpleGoal simpleGoal)
            {
                string completionStatus = simpleGoal.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{completionStatus} {goal.GetDetailsString()}");
            }
            else if (goal is EternalGoal eternalGoal)
            {
                // Eternal goals are never complete, so always show [ ]
                Console.WriteLine("[ ] " + eternalGoal.GetDetailsString());
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                // Show how many times the checklist goal has been completed
                string completionStatus = checklistGoal.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{completionStatus} {checklistGoal.GetDetailsString()}");
            }
            else if (goal is ProgressGoal progressGoal)
            {
                // Show how many times the progress goal has been completed
                string completionStatus = progressGoal.IsComplete() ? "[X]" : "[ ]";
                Console.WriteLine($"{completionStatus} {progressGoal.GetDetailsString()}");
            }
            else if (goal is NegativeGoal negativeGoal)
            {
                // Negative goals only display completion status
                Console.WriteLine("[ ] " + negativeGoal.GetDetailsString());
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple 2. Eternal 3. Checklist 4. Progress 5. Negative");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "4":
                Console.Write("Enter goal target (e.g., 100 miles): ");
                int goalTarget = int.Parse(Console.ReadLine());
                _goals.Add(new ProgressGoal(name, description, points, goalTarget));
                break;
            case "5":
                _goals.Add(new NegativeGoal(name, description, points));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        foreach (Goal goal in _goals)
        {
            if (goal.ShortName == name)
            {
                _score += goal.RecordEvent();
                break;
            }
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, description, points) { Completed = isComplete });
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus) { AmountCompleted = amountCompleted });
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}