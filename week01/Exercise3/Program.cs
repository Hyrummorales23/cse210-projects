using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess My Number game!");
        Console.WriteLine("Would you like to enter the magic number yourself (type '1') or let the computer generate it (type '2')?");

        // Ask the user if they want to enter the magic number or generate a random one
        int choice = int.Parse(Console.ReadLine());
        int magicNumber;

        if (choice == 1)
        {
            // User provides the magic number
            Console.Write("Enter the magic number: ");
            magicNumber = int.Parse(Console.ReadLine());
        }
        else
        {
            // Generate a random magic number
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100
            Console.WriteLine("The computer has generated a random magic number. Try to guess it!");
        }

        int guess = -1; // Initialize with a value different from the magic number

        // Loop until the guess matches the magic number
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it! Congratulations!");
            }
        }
    }
}