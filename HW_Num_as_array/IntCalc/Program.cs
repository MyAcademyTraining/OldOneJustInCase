using System;
using System.Linq;
using System.Numerics;

//Integer calculations

//Description

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

//Input

//On the first line you will receive 5 numbers separated by spaces
//Output

//Print their minimum, maximum, average, sum and product
//Each on a new line
//The average value should be printed with two digits of precision
//Constraints

//Each of the five numbers will be in the interval[-1000, 1000]
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//3 7 9 18 0	0
//18
//7.40
//37
//0

class Program
{
    static int Sumarry(params int[] input)
    {
        int sum = 0;
        foreach (int number in input)
        {
            sum += number;
        }
        return sum;
    }
    static int Minimum(params int[] input)
    {
        int min = int.MaxValue;
        foreach (int number in input)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

    static int Maximum(params int[] input)
    {
        int max = int.MinValue;
        foreach (int number in input)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }

    static double Average(params int[] input)
    {
        double avg = (double)(Sumarry(input)) / 5;
        return avg;

    }

    static BigInteger Product(params int[] input)
    {
        BigInteger prod = 1;
        foreach (int number in input)
        {
            prod *= number;
        }
        return prod;
    }
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(Minimum(input));
        Console.WriteLine(Maximum(input));
        Console.WriteLine("{0:0.00}", Average(input));
        Console.WriteLine(Sumarry(input));
        Console.WriteLine(Product(input));
    }
}

