using System;

//Reverse number
//Description

//Write a method that reverses the digits of a given decimal number.
//Input

//    On the first line you will receive a number

//Output

//    Print the given number with reversed digits

//Constraints

//    Time limit: 0.1s
//    Memory limit: 16MB

//Sample tests
//Input   Output
//256 	652
//123.45 	54.321

class Program
{

    static string Reverse(decimal input)
    {
        string same = input.ToString();

        string opossite = "";
        
        for (int i = same.Length-1; i >= 0; i--)
        {
            opossite += same[i];
        }
        return opossite;
    }

    static void Main(string[] args)
    {
        decimal input = decimal.Parse(Console.ReadLine());
        Console.WriteLine(Reverse(input));
    }
}

