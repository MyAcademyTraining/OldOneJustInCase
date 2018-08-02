using System;
using System.Linq;


//Write a method that checks if the element at given position in given array of integers is larger than its two 
//neighbours (when such exist). Write program that reads an array of numbers and prints how many of 
//them are larger than their neighbours.
//Input

//   On the first line you will receive the number N - the size of the array
//   On the second line you will receive N numbers separated by spaces - the array

//Output

//    Print how many numbers in the array are larger than their neighbours


class Program
{

    static int[] convertToArr(string input, int size)
    {
        int[] numbers = new int[size];
        numbers = input.Split(' ').Select(int.Parse).ToArray();
        return numbers;
    }

    static int CompareWNeighbours(int[] input)
    {
        int count = 0;
        for (int i = 1; i < input.Length - 1; i++)
        {
            if (input[i] > input[i - 1] && input[i] > input[i + 1])
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int[] numbers = convertToArr(input, size);
        Console.WriteLine(CompareWNeighbours(numbers));
    }
}

