using System;
using System.Numerics;

//Decimal to Hex

//Description

//Using loops write a program that converts an integer number to its hexadecimal representation.

//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input

//On the first and only line you will receive an integer in the decimal numeral system.
//Output

//On the only output line write the hexadecimal representation of the read number.
//Constraints

//All numbers will always be valid 64-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//254	FE
//6883	1AE3
//338583669684	4ED528CBB4
namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int baseValue = 1;
            int reminder;
            string hexValue = "";        

            while (input > 0)
            {
                reminder = input % 16;
                if (reminder == 10 )
                {
                    hexValue = hexValue + "A";
                }
                if (reminder == 11)
                {
                    hexValue = hexValue + "B";
                }
                if (reminder == 12)
                {
                    hexValue = hexValue + "C";
                }
                if (reminder == 13)
                {
                    hexValue = hexValue + "D";
                }
                if (reminder == 14)
                {
                    hexValue = hexValue + "D";
                }
                if (reminder == 15)
                {
                    hexValue = hexValue + "E";
                }
                hexValue = hexValue + reminder * baseValue;
                input = input / 16;
                baseValue = baseValue * 16;
            }
            Console.WriteLine(hexValue);
        }
    }
}


