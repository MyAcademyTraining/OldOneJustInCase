using System;

//Compare char arrays

//Write a program that compares two char arrays lexicographically(letter by letter).

//Input

//On the first line you will receive the first char array as a string
//On the second line you will receive the second char array as a string
//Output

//Print< if the first array is lexicographically smaller
//Print> if the second array is lexicographically smaller
//Print = if the arrays are equal
//Constraints

//1 <= size of arrays <= 128
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//hello
//halo	>
//food
//food =

class Program
{
    static void Main(string[] args)
    {
        //first
        string firstInput = Console.ReadLine();
        char[] firstArray = new char[firstInput.Length];
        firstArray = firstInput.ToCharArray();
        //second
        string secondInput = Console.ReadLine();
        char[] secondArray = new char[secondInput.Length];
        secondArray = secondInput.ToCharArray();
        char result = '=';
        int minLength = Math.Min(secondArray.Length, firstArray.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                result = '>';
                break;
            }
            else if (firstArray[i] < secondArray[i])
            {
                result = '<';
                break;
            }
        }
        if (result == '=' && firstArray.Length != secondArray.Length)
        {
            result = (secondArray.Length > firstArray.Length) ? '<' : '>';
        }
        Console.WriteLine(result);
    }
}

