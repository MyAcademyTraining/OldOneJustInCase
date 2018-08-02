using System;
using System.Numerics;

//Write a method that multiplies a number represented as an array of digits by a given integer number.Write a program to calculate N!.

//Input

//On the first line you will receive the number N
//Output

//Print N!
//Constraints

//0 <= N <= 100
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//5	120

namespace Factorial
{
    class Program
    {
        static BigInteger FactWithRec(int input)
        {
            if (input == 0)
            {
                return 1;
            }
            return input * FactWithRec(input - 1);
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger result = FactWithRec(input);
            Console.WriteLine(result);

        }
    }
}
