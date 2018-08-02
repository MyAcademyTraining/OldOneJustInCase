using System;
using System.Collections.Generic;
using System.Linq;


namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDim = new int[1,1];

            int[,,] threeDim = {
                {
                { 1,2,3},
                {4 ,5 ,6 }
                },
                {
                    {7 ,8,9 },
                    {10 , 11 ,12 }
                }
            };
            Console.WriteLine(threeDim.GetLength(0));
            Console.WriteLine(threeDim.GetLength(1));
            Console.WriteLine(threeDim.GetLength(2));

        }
    }
}
