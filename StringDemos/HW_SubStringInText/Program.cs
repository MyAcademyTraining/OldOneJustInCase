using System;
using System.Collections.Generic;

//Sub-string in text
//Description

//Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).
//Input

//    On the first line you will receive a string - the pattern
//    On the second line you will receive a string - the text

//Output

//    Print a number on a single line
//        The number of occurrences


class Program
{
    static int AllIndexes(string text, string searchedValue)
    {
        List<int> indexes = new List<int>();
        int currentIndex = text.IndexOf(searchedValue, 0);
        while (currentIndex != -1)
        {
            indexes.Add(currentIndex);
            currentIndex = text.IndexOf(searchedValue, currentIndex + searchedValue.Length);
        }
        return indexes.Count;
    }
    static void Main(string[] args)
    {
        string pattern = Console.ReadLine().ToLower();
        string text = Console.ReadLine().ToLower();

        Console.WriteLine(AllIndexes(text, pattern));
    }
}

