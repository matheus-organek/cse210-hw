using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"\nYour grade is: {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You did it.");
        }
        else
        {
            Console.WriteLine("I'm sorry, you've failed. Try again.");
        }
    }
}