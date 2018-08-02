using System;
using System.Numerics;
//Binary to Decimal

//Description

//Using loops write a program that converts a binary integer number to its decimal form.

//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Input

//You will receive exactly one line containing an integer number representation in binary
//Output

//On the only output line write the decimal representation of the number
//Constraints

//All input numbers will be valid 32-bit integers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger baseValue = 1;
            BigInteger reminder;
            BigInteger decimal_val = 0;
            BigInteger binary_val = input;
            while (input > 0)
            {
                reminder = input % 10;
                decimal_val = decimal_val + reminder * baseValue;
                input = input / 10;
                baseValue = baseValue * 2;
            }
            Console.WriteLine(decimal_val);
        }
    }
}
