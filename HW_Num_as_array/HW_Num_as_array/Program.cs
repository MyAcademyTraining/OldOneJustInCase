using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two positive integer numbers represented as arrays of digits(each array element arr[i] contains a
//digit; the last digit is kept in arr[0]). Write a program that reads two arrays representing positive integers and outputs
//their sum.

//Input


//On the first line you will receive two numbers separated by spaces - the size of each array
//On the second line you will receive the first array
//On the third line you will receive the second array
//Output


//Print the sum as an array of digits (as described)
//Digits should be separated by spaces

namespace HW_Num_as_array
{
    class Program
    {

        static string ArraySumator(int[] first, int[] second, int firstSize, int secSize)
        {
            int resultSize = 0;

            resultSize = firstSize < secSize ?  secSize : firstSize;
            int[] result = new int[resultSize];
            int j = 0;
            if (firstSize >= secSize)
            {
                for (int i = secSize-1; i >= 0; i--)
                {
                    int temp = 0;
                    if ((first[i] + second[i])>10)
                    {
                        temp = 1;
                    }
                    result[j] = (first[i] + second[i])%10 + temp;
                    j++;
                    Console.WriteLine(result[j]);
                }

                for (int i = firstSize - 1; i >= secSize; i--)
                {
                    result[j] = first[i];
                }
            }
            else
            {
                for (int i = firstSize - 1; i >= 0; i--)
                {
                    int temp = 0;
                    if ((first[i] + second[i]) > 0)
                    {
                        temp = 1;
                    }
                    result[j] = first[i] + second[i] + temp;
                    j++;
                }
                for (int i = secSize - 1; i >= firstSize; i--)
                {
                    result[j] = second[i];
                }
            }

            string output = result.ToString();
            return output;
        }

        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sizeFirst = sizes[0];
            int sizeSec = sizes[1];
            int[] firstNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(ArraySumator(firstNum,secNum,sizeFirst,sizeSec));
        }
    }
}
