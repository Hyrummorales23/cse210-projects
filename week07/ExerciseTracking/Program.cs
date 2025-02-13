using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 02, 10), 30, 3.0),
            new Cycling(new DateTime(2025, 02, 11), 45, 15.0),
            new Swimming(new DateTime(2025, 02, 12), 60, 40),
            new Running(new DateTime(2025, 02, 13), 25, 4.0)
        };
        Console.WriteLine();

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}