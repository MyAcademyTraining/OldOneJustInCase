using System;

//Maximal K sum

//Description

//Write a program that reads two integer numbers N and K and an array of N elements from the console.Find the maximal sum of K elements in the array.

//Input

//On the first line you will receive the number N
//On the second line you will receive the number K
//On the next N lines the numbers of the array will be given
//Output

//Print the maximal sum of K elements in the array
//Constraints

//1 <= N <= 1024
//1 <= K <= N
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//8
//3
//3
//2
//3
//-2
//5
//4
//2
//7	        16

class MaxKSum
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int sumCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        int sum = 0;
        for (int i = num-1; i > num - sumCount - 1; i--)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}