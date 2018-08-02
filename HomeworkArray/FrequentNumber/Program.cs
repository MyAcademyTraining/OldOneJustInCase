using System;

//Write a program that finds the most frequent number in an array of N elements.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the most frequent number and how many time it is repeated
//Output should be REPEATING_NUMBER(REPEATED_TIMES times)
//Constraints

//1 <= N <= 1024
//0 <= each number in the array <= 10000
//There will be only one most frequent number

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
        int mostFrequent = 0;
        int frequency = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int tempfrequency = 1;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    tempfrequency++;
                }
            }
            if (tempfrequency > frequency)
            {
                frequency = tempfrequency;
                mostFrequent = i;
            }
        }
        Console.WriteLine("{0} ({1} times)", numbers[mostFrequent], frequency);
    }
}
