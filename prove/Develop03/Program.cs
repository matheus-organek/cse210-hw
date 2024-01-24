using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Jhon", 3, 16);
        Console.WriteLine(r1.GetDisplayText());

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(r2.GetDisplayText());

    }
}