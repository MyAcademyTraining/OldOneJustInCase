using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//First larger than neighbours
//Description

//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//    or -1, if there is no such element.
//Input

//    On the first line you will receive the number N - the size of the array
//    On the second line you will receive N numbers sepated by spaces - the array

//Output

//    Print the index of the first element that is larger than its neighbours or -1 if none are



namespace FirstLarger
{
    class Program
    {

        static int[] convertToArr(string input, int size)
        {
            int[] numbers = new int[size];
            numbers = input.Split(' ').Select(int.Parse).ToArray();
            return numbers;
        }

        static int Larger(int[] input)
        {
            int largest = -1;
            for (int i = 1; i < input.Length - 1; i++)
            {
                if (input[i] > input[i - 1] && input[i] > input[i + 1])
                {
                    largest = i;
                    break;
                }
            }
            return largest;
        }

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] numbers = convertToArr(input, size);
            Console.WriteLine(Larger(numbers));
        }
    }
}
