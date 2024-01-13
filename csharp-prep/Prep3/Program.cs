using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What's your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}