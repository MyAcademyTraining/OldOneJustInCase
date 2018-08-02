using System;
using System.Linq;

//Description

//Write a method that counts how many times given number appears in a given array.Write a test program to check if the method is working correctly.
//Input


//   On the first line you will receive a number N - the size of the array
//   On the second line you will receive N numbers separated by spaces - the numbers in the array

//   On the third line you will receive a number X


//Output

//   Print how many times the number X appears in the array


class Program
{

    static int[] convertToArr(string input, int size)
    {
        int[] numbers = new int[size];
        numbers = input.Split(' ').Select(int.Parse).ToArray();
        return numbers;
    }

    static int searching(int[] numbers, int searchedVal)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (searchedVal == numbers[i])
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int searched = int.Parse(Console.ReadLine());
        int[] num = convertToArr(input, size);
        Console.WriteLine(searching (num, searched));
    }
}

