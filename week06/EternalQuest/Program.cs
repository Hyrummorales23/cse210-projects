using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record goal event");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.ListGoalDetails();
                    break;
                case "3":
                    goalManager.RecordEvent();
                    break;
                case "4":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "5":
                    goalManager.SaveGoals();
                    break;
                case "6":
                    goalManager.LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}

// Exceeding Requirements Comment:

// I decided to add two new goal types: ProgressGoal (track progress towards a large goal) 
//(e.g., "Run a marathon")

// and NegativeGoal (losing points for bad habits).
//(e.g., "Skip gym")

// This classes help me add more gamification elements to my program.
