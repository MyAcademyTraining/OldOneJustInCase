using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Description

//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with*.


class HWStrLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        foreach (char i in input)
        {
            output.Append(i);
        }
        output.Append('*', (20 - input.Length));
        Console.WriteLine(output);
    }
}

