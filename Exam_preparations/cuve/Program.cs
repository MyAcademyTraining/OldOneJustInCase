using System;


    class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        //int n = 5; we start thinking by this
        int fieldsize = n * 2 - 1;
        int mid = n - 1;
        char empty = ' ';
        char top = '/';
        char side = 'X';
        char edge = ':';
        for (int row = 0; row < fieldsize; row++)
        {
            for (int columns = 0; columns < fieldsize; columns++)
            {
                if (columns == 0 && row >= mid || 
                    columns ==mid && row >= mid ||
                    columns == fieldsize-1 && row <= mid||
                    columns >= mid && row == 0||
                    columns <= mid && row == mid ||
                    columns <= mid && row == fieldsize -1 ||
                    columns + row == mid ||// first diagonal 
                    columns + row == fieldsize -1 + mid ||// second diagonal
                    columns + row == fieldsize-1 && row <=mid)
                { // vertical lines
                    Console.Write(edge);
                }
                else if (columns >mid && 
                    columns + row < fieldsize + mid &&
                    columns + row >= fieldsize - 1 )
                {
                    Console.Write(side);
                }
                else if(row<mid && columns + row >= mid)
                {
                    Console.Write(top);
                }
                else
                {
                    Console.Write(empty);
                }
                
            }
            Console.WriteLine();
        }
        }
    }

