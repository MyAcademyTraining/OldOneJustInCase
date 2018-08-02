//Trailing 0 in N!

//Description

//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.

//Your program should work well for very big numbers, e.g.N = 100000.
//Input

//On the only input line, you will receive a single integer - the number N
//Output

//Output a single number - the count of trailing zeroes for the N!
//Constraints

//N will always be a valid positive integer number.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output Explanation
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailing0inN_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int Zeroes = 0;
            for (int power5 = 5; power5 <= number; power5 *= 5)
            {
                Zeroes += number / power5;
            }
            Console.WriteLine(Zeroes);
        }
    }
}
