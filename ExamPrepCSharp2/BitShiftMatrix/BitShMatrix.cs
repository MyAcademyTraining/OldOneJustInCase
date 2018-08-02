using System;
using System.Linq;
using System.Numerics;

namespace BitShiftMatrix
{
    class BitShMatrix
    {
        class Position
        {
            public int Row;
            public int Col;
        }

        static BigInteger[,] CreateAndFillMatrx(int rows, int columns)
        {
            BigInteger[,] matrix = new BigInteger[rows, columns];
            BigInteger filler = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[rows - i - 1, j] = filler << j;
                }
                filler = filler << 1;
            }
            return matrix;
        }

        static BigInteger FindSum(BigInteger[,] matrix, int[] moves, int coef)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            bool[,] isChecked = new bool[rows, columns];

            BigInteger sum = 0;
            int lastColumnfound = 0;
            int lastRowfound = rows - 1;

            var lastFoundPos = new Position() { Row = rows - 1, Col = 0 };

            int currentTarget = 0;
            while (currentTarget < moves.Length)
            {

                var targetPos = new Position()
                {
                    Row = moves[currentTarget] / coef,
                    Col = moves[currentTarget] % coef
                };

                int targetColumn = moves[currentTarget] % coef;
                int columnDirection = (lastColumnfound < targetColumn) ? 1 : -1;

                for (int i = lastColumnfound; i != targetColumn + columnDirection; i += columnDirection)
                {
                    if (isChecked[lastRowfound, i] == false)
                    {
                        sum = sum + matrix[lastRowfound, i];
                        isChecked[lastRowfound, i] = true;
                    }
                }
                lastColumnfound = targetColumn;

                int targetRow = moves[currentTarget] / coef;
                int rowDirection = (lastRowfound < targetRow) ? 1 : -1;

                for (int j = lastRowfound; j != targetRow + rowDirection; j += rowDirection)
                {
                    if (isChecked[j, lastColumnfound] == false)
                    {
                        sum = sum + matrix[j, lastColumnfound];
                        isChecked[j, lastColumnfound] = true;
                    }
                }

                lastRowfound = targetRow;

                currentTarget++;
            }
            return sum;
        }
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());//We don't use it 

            int coef = Math.Max(rows, columns);
            BigInteger[,] matrix = CreateAndFillMatrx(rows, columns);

            int[] moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BigInteger sum = FindSum(matrix, moves, coef);

            Console.WriteLine(sum);

        }
    }
}
