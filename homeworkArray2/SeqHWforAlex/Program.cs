using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a matrix of strings of size N x M.Sequences in the matrix we define as sets of several neighbour elements 
//located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

namespace SeqHWforAlex
{
    class Program
    {
        static int FindLongest(int[,] input, int rows, int columns) //[rows,columns]
        {
            bool[,] isChecked = new bool[rows, columns];
            int MaxSum = int.MinValue;
            int currentRow = 0;
            int currentSum = 0;

            while (currentRow < rows)//check columns
            {
                for (int i = 0; i < columns - 1; i++)
                {
                    while (input[currentRow, i] == input[currentRow, i + 1])
                    {
                        isChecked[currentRow, i] = true;
                        i++;
                        if (isChecked[currentRow,i+1] ==false)
                        {
                            currentSum++;
                        }
                    }
                    if (currentSum > MaxSum)
                    {
                        MaxSum = currentSum;
                    }

                    i++;
                }
                currentRow++;
            }

        

            return MaxSum;
        }
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int[,] Ma3x = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            for (int j = 0; j < columns; j++)
            {
                Ma3x[i, j] = int.Parse(temp[j]);
            }
        }
    }
}
}
