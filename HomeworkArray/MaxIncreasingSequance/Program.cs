﻿using System;

//Maximal increasing sequence

//Description

//Write a program that finds the length of the maximal increasing sequence in an array of N integers.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the length of the maximal increasing sequence
//Constraints

//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//8
//7
//3
//2
//3
//4
//2
//2
//4	3

class MaxIncreasingSequence
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int tempLength = 0;
        int maxLength = 0;
        for (int i = 1; i < num; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                tempLength++;
            }
            else
            {
                tempLength = 0;
            }
            if (tempLength > maxLength)
            {
                maxLength = tempLength;
            }
        }
        Console.WriteLine(maxLength + 1);
    }
}
