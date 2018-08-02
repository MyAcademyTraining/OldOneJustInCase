using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Description

//You are given a sequence of positive integer values written into a string, separated by spaces.Write a function that reads these values from given string and calculates their sum.Write a program that reads a string of positive integers separated by spaces and prints their sum.
//Input

//  On the only line you will receive a string consisted of positive integers

    
    class IntegersSum
    {
    static int sum(int[] input)
    {
        int sum = 0;
        foreach (int num in input)
        {
            sum += num;
        }
        return sum;
    }
        static void Main()
        {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(sum(input));
        }
    }

