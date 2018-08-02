using System;

//Binary search

//Description

//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//On the last line you will receive the number X
//Output

//Print the index where X is in the array
//If there is more than one occurence print the first one
//If there are no occurences print -1
//Constraints

//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//10
//1
//2
//4
//8
//16
//31
//32
//64
//77
//99
//32	6

class BinarySearch
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int target = int.Parse(Console.ReadLine());
        int targetPosition = -1;
        if (target < numbers[numbers.Length / 2])
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] == target)
                {
                    targetPosition = i;
                    break;
                }
            }
        }
        else
        {
            for (int i = numbers.Length / 2; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    targetPosition = i;
                    break;
                }
            }
        }
        Console.WriteLine(targetPosition);
    }
}

