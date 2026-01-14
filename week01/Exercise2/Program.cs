using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "";

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Determine + or -
        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle special cases
        // No A+ allowed
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // No F+ or F- allowed
        if (letter == "F")
        {
            sign = "";
        }

        // Print the final grade once
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine pass or fail
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course 🎉");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying and you'll do better next time 💪");
        }
    }
