using System;

//Fill the matrix

//Description

//Write a program that fills and prints a matrix of size(n, n) as shown below.

//Input


//On the first line you will receive the number N
//On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
//Output

//Print the matrix
//Numbers on a row must be separated by a single spacebar
//Each row must be on a new line

namespace FillMa3x
{
    class Program
    {
        static int[,] Ma3xFilling(int dimension)
        {
            int temp = 1;
            int[,] Ma3x = new int[dimension, dimension];
            for (int colls = 0; colls < dimension; colls++)
            {
                for (int rows = 0; rows < dimension; rows++)
                {
                    Ma3x[rows, colls] = temp;
                    temp++;
                }
            }
            return Ma3x;
        }

        static void Main()
        {
            int dimension = int.Parse(Console.ReadLine());
           // char determinator = char.Parse(Console.ReadLine());
            int[,] Ma3x = Ma3xFilling(dimension);

            //if (determinator == 'a')
            //{
            //    for (int colls = 0; colls < dimension; colls++)
            //    {
            //        for (int rows = 0; rows < dimension; rows++)
            //        {
            //            Console.Write("{0, 3}", Ma3x[colls, rows]);
            //        }

            //        Console.WriteLine();
            //    }
            //}

            for (int colls = 0; colls < dimension; colls++)
            {
                if (colls % 2 == 0)
                {


                    for (int rows = 0; rows < dimension; rows++)
                    {
                        Console.Write("{0, 3}", Ma3x[rows, colls]);
                    }

                    Console.WriteLine();
                }
                else
                {
                    for (int rows = 0; rows < dimension; rows++)
                    {
                        Console.Write("{0, 3}", Ma3x[colls, rows]);
                    }

                    Console.WriteLine();
                }
            }

        }
    }
}
