using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that calculates N! / K! for given N and K.

//Use only one loop.
//Input

//On the first line, there will be only one number - N
//On the second line, there will be only one number - K
//Output

//Output a single line, consisting of the result from the calculation described above.
//Constraints

//1 < K<N< 100
//Hint: overflow is possible
//N and K will always be valid integer numbers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//5
//2	60
//6
//5	6
//8
//3	6720
namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = int.Parse(Console.ReadLine());
            int delimiter = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = delimiter+1; i <= numerator; ++i)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
