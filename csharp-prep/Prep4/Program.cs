using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }          
        }


        int sum = 0;
        int max = numbers[0];
        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
                {
                    max = number;
                }
        }

        float average = ((float)sum) / numbers.Count;


        Console.WriteLine($"\nThe sum is: {sum}.");
        Console.WriteLine($"\nThe average is: {average}.");
        Console.WriteLine($"\nThe largest number is: {max}.");
    }
}