using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Input

//    On the only input line you will receive a string

//Output

//    Print the string in C# Unicode character literals on a single line



class UnicodeChar
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            sb.AppendFormat("\\u{0:X4}", (uint)c);
        }
        Console.WriteLine(sb.ToString());
    }
}
