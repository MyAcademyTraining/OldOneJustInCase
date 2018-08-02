using System;
using System.Linq;

namespace SequenceInMa3x
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] InputLength = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[InputLength[0], InputLength[1]];
            

            for (int i = 0; i < InputLength[0]; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int col = 0;
                foreach (var singlerow in row)
                {
                    matrix[i, col] = singlerow;
                    col++;
                }
            }

            int sum = 0;
            int temp = matrix[0,0];
            for (int i = 0; i < InputLength[0]; i++)
            {

                for (int j = 0; j < InputLength[1]; j++)
                {

                }
            }
            Console.WriteLine(sum);
        }
    }
}
