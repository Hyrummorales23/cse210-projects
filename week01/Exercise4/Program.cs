using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the user
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break; // Stop when the user enters 0
            }

            numbers.Add(number); // Add the number to the list
        }

        // Compute the sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        if (numbers.Count > 0) // Ensure no division by zero
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }

        // Find the maximum number
        if (numbers.Count > 0)
        {
            int max = numbers[0]; // Assume the first number is the largest
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}