using System;
using System.Numerics;
//Catalan Numbers

//Description

//In combinatorics, the Catalan numbers are calculated by the following formula

//Write a program to calculate the Nth Catalan number by given N
//Input

//On the only line, you will receive the number N
//Output

//Output a single number - the Nth Catalan number
//Constraints

//N will always be a valid integer number in the range[0, 100]
//Hint: overflow is possible.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//0	1
//5	42
//10	16796
//15	9694845


namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int catalan = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            BigInteger numerator = 1;
            BigInteger denominator = 1;
            for (int i = 2 * catalan; i >= catalan + 2; i--)
            {
                numerator *= i;
            }
            for (int i = 1; i <= catalan; i++)
            {
                denominator *= i;
            }
            result = numerator / denominator;
            Console.WriteLine(result);
        }
    }
}
