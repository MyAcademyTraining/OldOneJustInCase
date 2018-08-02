using System;
//Write a program that finds all prime numbers in the range[1...N]. Use the Sieve of Eratosthenes algorithm.
//The program should print the biggest prime number which is <= N.

//Input

//On the first line you will receive the number N
//Output

//Print the biggest prime number which is <= N
//Constraints

//2 <= N <= 10 000 000
//Time limit: 0.3s
//Memory limit: 64MB
//Sample tests

//Input   Output
//13	13
//126	113
//26	23

class primeNumbersErathosten
{
    static void Main(string[] args)
    {
        // Input
        int prime = int.Parse(Console.ReadLine());
        int[] numbers = new int[prime];
        for (int i = 1; i < prime; i++)
        {
            numbers[i] += i;
        }
        // Findind prime numbers according to Erathosten
        for (int i = 2; i < prime; i++)
        {
            for (int j = 2; j < prime; j++)
            {
                if (i * j < prime)
                {
                    numbers[i * j] = 0;
                }
            }
        }
        for (int i = prime - 1; i > 1; i--)
        {
            if (numbers[i] != 0)
            {
                Console.WriteLine(numbers[i]);
                break;
            }
        }

    }
}

