using System;

//Sort 3 Numbers

//Description

//Write a program that enters 3 real numbers and prints them sorted in descending order.

//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.
//Input

//On the first three lines, you will receive the three numbers, each on a separate line.
//Output

//Output a single line on the console - the sorted numbers, separated by a whitespace
//Constraints

//The three numbers will always be valid integer numbers in the range [-1000, 1000]
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//3
//2
//1	3 2 1
//-5
//3
//-5	3 -5 -5
//1
//2
//20	20 2 1
//Submission



namespace lec_5_homework
{
    class Program
    {
        static void Main()
        {
            string input;
            input = Console.ReadLine();
            int a = int.Parse(input);
            input = Console.ReadLine();
            int b = int.Parse(input);
            input = Console.ReadLine();
            int c = int.Parse(input);
            PrintSortedNumbers(a, b, c);

        }
        private static void PrintSortedNumbers(int a, int b, int c)
        {
            if (a >= c && a >= b)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if (b >= c && b >= a)
            {
                if (c >= a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
            }
            else if (c >= a && c >= b)
            {
                if (a >= b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }
    }
}
