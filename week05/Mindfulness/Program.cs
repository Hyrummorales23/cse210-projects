using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") new BreathingActivity().Run();
            else if (choice == "2") new ListingActivity().Run();
            else if (choice == "3") new ReflectingActivity().Run();
            else if (choice == "4") break;
        }
    }
}

// Exceeding Requirement Implemented:
// In the Reflection and Listing activities, I have ensured that prompts are not 
// repeated until all have been used at least once in a session.

// This is achieved by maintaining a list of unused prompts and only resetting the list once all 
// prompts have been displayed.