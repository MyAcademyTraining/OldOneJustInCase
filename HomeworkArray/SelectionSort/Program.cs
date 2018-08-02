using System;

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the sorted array
//Each number should be on a new line
//Constraints

//1 <= N <= 1024
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];
        int posMin, temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            posMin = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[posMin])
                {
                    posMin = j;
                }
            }
            if (posMin != i)
            {
                temp = numbers[i];
                numbers[i] = numbers[posMin];
                numbers[posMin] = temp;
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

