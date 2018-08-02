using System;

namespace bitmask
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {


                int bitToTake = i;
                int mask = 1 << bitToTake;
                int maskAndNumber = input & mask;
                int finalBits = maskAndNumber >> bitToTake;
                if (finalBits == 0)
                {
                    Console.WriteLine("A" + (10 - i));
                }
            }
        }

    }
}
