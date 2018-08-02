using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecTry
{
    class Program
    {
        static int[] ReverseintArrays(int[] Array)
        {
            int[] temp = new int[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                temp[i] = Array[i];
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = temp[Array.Length - i - 1];
            }
            return Array;
        }

        static int[] CalcBiggerFirst(int[] big, int[] small)
        {
            int[] result = new int[big.Length];
            int additional = 0;
            int sum = 0;
            int digit = 0;
            for (int i = 0; i < big.Length; i++)
            {
                if (i < small.Length)
                {
                    sum = big[i] + small[i] + additional;
                    digit = sum % 10;
                    additional = sum / 10;
                    result[i] = digit;
                }
                else
                {
                    sum = big[i] + additional;
                    digit = sum % 10;
                    additional = sum / 10;
                    result[i] = digit;
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // No need
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (secondArray.Length > firstArray.Length)
            {
                int[] output = CalcBiggerFirst(secondArray, firstArray);
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write("{0} ", output[i]);
                }
            }
            else
            {
                int[] output = CalcBiggerFirst(firstArray, secondArray);
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write("{0} ", output[i]);
                }
            }
            
           // output = ReverseintArrays(output);
            
        }
    }
}

