using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main()
        {
            int[,] Matrix = FindAndFillTheMatrix();
            int rowsAndcolls = Matrix.GetLength(0);
            BigInteger Sum = 0;
            BigInteger diagSum = 0;
            for (int row = 0; row < rowsAndcolls; row++)
            {
                for (int coll = 0; coll < rowsAndcolls; coll++)
                {
                    if (row == coll)
                    {
                        diagSum += Matrix[row, coll];
                    }
                    if (row < (rowsAndcolls - 2) && (coll < rowsAndcolls - 4))
                    {
                        if (Matrix[row, coll] + 1 == (Matrix[row, coll + 1])
                            && Matrix[row, coll + 1] + 1 == (Matrix[row, coll + 2])
                            && Matrix[row, coll + 2] + 1 == (Matrix[row + 1, coll + 2])
                            && Matrix[row + 1, coll + 2] + 1 == (Matrix[row + 2, coll + 2])
                            && Matrix[row + 2, coll + 2] + 1 == (Matrix[row + 2, coll + 3])
                            && Matrix[row + 2, coll + 3] + 1 == (Matrix[row + 2, coll + 4]))
                        {
                            long TempSum = Matrix[row, coll] * 7 + 21;
                            if (TempSum > Sum)
                            {
                                Sum = TempSum;
                            }

                        }
                    }
                }
            }
            if (Sum != 0)
            {
                Console.WriteLine("YES {0}",Sum);
            }
            else
            {
                Console.WriteLine("NO {0}",diagSum);
            }

        }

        private static int[,] FindAndFillTheMatrix()
        {
            int rowAndCow = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[rowAndCow, rowAndCow];

            for (int i = 0; i < rowAndCow; i++)
            {
                int[] currentRow = new int[rowAndCow];
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < rowAndCow; j++)
                {
                    Matrix[i, j] = int.Parse(temp[j]);
                }
            }
            return Matrix;
        }
    }
}
