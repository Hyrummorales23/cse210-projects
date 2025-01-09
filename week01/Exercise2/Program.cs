using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // Determine letter

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine sign
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit >= 3)
        {
            sign = "";
        }
        else
        {
            sign = "-";
        }

        //Exception on the sign for the letter grade
        if (letter == "A" && lastDigit <= 2)
        {
            sign = "-";  // No A+ grade
        }
        else if (letter == "A" && lastDigit > 2)
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";  // No F+ or F- grade
        }

        // Letter grade with sign display
        Console.WriteLine($"Your letter grade is: {letter}{sign}.");

        // Determine Pass/Fail and display message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, You passed the course!");
        }
        else
        {
            Console.WriteLine("Keep Trying! You can do better next time.");
        }

    }
}