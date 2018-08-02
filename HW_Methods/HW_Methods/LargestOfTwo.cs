using System;
using System.Linq;

//Get largest number
//Description

//Write a method GetMax() with two parameters that returns the larger of two integers.Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
//Input

//    On the first line you will receive 3 integers separated by spaces

//Output

//    Print the largest of them


    class LargestOfTwo
    {
        static int GetMax(string numbers,char separator =' ')
        {
            int largest = int.MinValue;
            int[] num = numbers.Split(' ').Select(int.Parse).ToArray();
            foreach (int number in num)
            {
                if (number >= largest)
                {
                    largest = number;
                }
            }

            return largest;
        }
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            Console.WriteLine(GetMax(numbers)); 
        }
    }

