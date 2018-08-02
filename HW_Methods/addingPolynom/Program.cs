using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two polynomials.Represent them as arrays of their coefficients.
//Write a program that reads two polynomials and prints their sum.
//Input

//   On the first line you will receive the number N
//   On the second line you will receive the first polynomial as coefficients separated by spaces

//   On the third line you will receive the second polynomial as coefficients separated by spaces


//Output

//   Print the sum of the polynomials

class addingPolynom
{
    static int[] FindCoeficients(int[] first, int[] second)
    {
        int[] result = new int[first.Length];
        for (int i = 0; i < first.Length; i++)
        {
            result[i] = first[i] + second[i];
        }
        return result;
    }
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] result = FindCoeficients(first, second);
        foreach (int number in result)
        {
            Console.Write(number+ " ");    
        }
    }
}

