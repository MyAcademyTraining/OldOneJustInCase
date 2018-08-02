using System;

//Description

//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

//Can you do it with only one loop (with single scan through the elements of the array)?
//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the maximal sum of consecutive numbers

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int maxsum, sum;
            maxsum = sum = 0;
            //Kadane’s Algorithm
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = 0;
                for (int k = i; k < numbers.Length; k++)
                {
                    sum += numbers[k];
                    if (sum > maxsum)
                    {
                        maxsum = sum;
                    }
                }
            }
            Console.WriteLine(maxsum);
        }
    }
}
