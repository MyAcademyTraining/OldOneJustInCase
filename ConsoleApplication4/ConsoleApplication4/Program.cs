using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your birth month:");
            int month = Console.Read();
            Console.WriteLine("Please enter your birth day:");
            int day = Console.Read();
            Console.WriteLine("Please enter your birth year:");
            int year = Console.Read();
            if (year >= 0)
                Console.WriteLine("Fuckin cheater");
            else
                {
                Console.WriteLine("B-day date is");
                Console.WriteLine(month + day + year);
                }
        }
    }
}
