using System;
//Compare arrays

//Description

//Write a program that reads two integer arrays of size N from the console and compares them element by element.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the first array will be given
//On the next N lines the numbers of the second array will be given
//Output

//Print Equal if the two arrays are the same and Not equal if they are not
//Constraints

//1 <= N <= 20
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//3
//1
//2
//3
//1
//2
//3	Equal
//3
//1
//1
//1
//2
//2
//2	Not equal

    class CompareArrays
    {
        static void Main()
        {
        int size = int.Parse(Console.ReadLine());
        int[] first = new int[size];
        int[] second = new int[size];
        bool comparison = true;
        for (int i = 0; i < size; i++)
        {
            first[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            second[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            if (first[i] != second[i])
            {
                comparison = false;
                break;
            }
        }
        if (comparison == true)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
    }

