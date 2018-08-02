using System;
using System.Collections.Generic;
using System.Numerics;


//Decimal to hexadecimal

//Description

//Write a program that converts a decimal number N to its hexadecimal representation.

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the hexadecimal representation of N on a single line
//There should not be leading zeros
//Use uppercase letters
//Constraints

//1 <= N <= 1018
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//19	13

class DecToHex
    {
    static List<char> DecToHexConv(BigInteger decNumber)
    {
        BigInteger temp = 0;
        List<char> result = new List<char>();
        char[] Hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        while (decNumber >0)
        {
            temp = decNumber % 16;
            result.Add(Hex[(int)temp]);
            decNumber /= 16;
        }
        result.Reverse();
        return result;
    }

        static void Main()
        {
        BigInteger input = int.Parse(Console.ReadLine());
        List<char> result = DecToHexConv(input);
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        }
    }

