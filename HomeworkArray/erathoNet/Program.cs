using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool[] numbers = new bool[num];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = true;
        }

        int max = (int)Math.Sqrt(numbers.Length);

        for (int i = 2; i <= max; i++)
        {
            if (numbers[i])
            {
                for (int j = i * i; j < numbers.Length; j += i)
                {
                    numbers[j] = false;
                }
            }
        }

        for (int i = numbers.Length-1; i > 0; i--)
        {
            if (numbers[i])
            {
                Console.Write(i);
                break;
            }
        }
    }
}