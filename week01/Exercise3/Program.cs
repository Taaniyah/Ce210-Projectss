using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
    }
    using System;

class Program
{
    static void Main()
    {
        // Ask the user for the magic number
        Console.Write("Enter the magic number: ");
        int magicNumber = int.Parse(Console.ReadLine());

        // Ask the user for a guess
        Console.Write("Enter your guess: ");
        int guess = int.Parse(Console.ReadLine());

        // Determine if the guess is higher, lower, or correct
        if (guess < magicNumber)
        {
            Console.WriteLine("Guess higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Guess lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }
}
