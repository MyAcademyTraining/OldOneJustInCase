using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Series of letters
//Description

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Input

//    On the only input line you will receive a string

//Output

//    Print the string without consecutive identical letters



class SeriesOfLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] text = input.ToCharArray();
        for (int i = 0; i < input.Length-1; i++)
        {
            if (text[i] == text [i+1])
            {
                text[i] = '|';
            }
        }
        StringBuilder result = new StringBuilder();
        foreach (char symbol in text)
        {
            if (symbol!='|')
            {
                result.Append(symbol);
            }
        }
        Console.WriteLine(result);
    }
}

