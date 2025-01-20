using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the Fraction class with each constructor
        Fraction fraction1 = new Fraction(); //Should be 1/1
        Fraction fraction2 = new Fraction(6); //Should be 6/1
        Fraction fraction3 = new Fraction(3, 4); //Should be 3/4

        //Display as string
        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString());

        //Display decimals
        Console.WriteLine("Fraction 1 as decimal: " + fraction1.GetDecimalValue());
        Console.WriteLine("Fraction 2 as decimal: " + fraction2.GetDecimalValue());
        Console.WriteLine("Fraction 3 as decimal: " + fraction3.GetDecimalValue());

        //Modify and display fraction1
        fraction1.SetNumerator(2);
        fraction1.SetDenominator(5);
        Console.WriteLine("Updated Fraction1: " + fraction1.GetFractionString());
        Console.WriteLine("Updated Fraction 1 as decimal: " + fraction1.GetDecimalValue());
    }
}