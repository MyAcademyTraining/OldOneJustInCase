//Biggest of 5

//Description

//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

//Input

//On the first 5 lines you will receive the 5 numbers, each on a separate line
//Output

//On the only output line, write the biggest of the 5 numbers
//Constraints

//The 5 numbers will always be valid floating-point numbers in the range[-200, 200]
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//4
//4
//4
//4
//4	4
//-0.5
//-10
//0
//-1
//-3	0
using System;

namespace BiggestOfFive
{
    class Program
    {
        static void Main()
        {
            string input;
            input = Console.ReadLine();
            float a = float.Parse(input);
            input = Console.ReadLine();
            float b = float.Parse(input);
            input = Console.ReadLine();
            float c = float.Parse(input);
            input = Console.ReadLine();
            float d = float.Parse(input);
            input = Console.ReadLine();
            float e = float.Parse(input);
            BiggestOfFive(a, b, c, d, e);
        }
        private static void BiggestOfFive(float a, float b, float c, float d, float e)
        {
            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("{0}", a);
            }
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                Console.WriteLine("{0}", b);
            }
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("{0}", c);
            }
            else if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("{0}", d);
            }
            else if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("{0}", e);
            }
        }
    }
}
