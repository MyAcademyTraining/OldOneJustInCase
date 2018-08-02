using System;
using System.Numerics;

//Write a program that converts a binary number N to its decimal representation.

//Input

//On the only line you will receive a binary number - N
//There will not be leading zeros
//Output

//Print the decimal representation of N on a single line
//There should not be leading zeros


    class Program
    {
    static BigInteger Bin2Dec(string input)
    {
        BigInteger sum = 0;

        foreach (char bit in input)
        {
            sum = (bit - '0') + sum * 2;
        }

        return sum;
    }

        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        Console.WriteLine(Bin2Dec(input));
        }
    }

