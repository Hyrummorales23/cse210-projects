using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompting the user to enter its first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompting the user to enter its last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Displaying the name as James Bond Style
        Console.WriteLine($"Yor name is {lastName}, {firstName} {lastName}. ");
    }
}