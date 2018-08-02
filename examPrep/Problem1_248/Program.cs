using System;
using System.Numerics;

//Molly and Molly communicate with a secret algorithm.It accepts three numbers, one of which is a secret code, 
//defining a mathematical (don’t hate us, math is a universal language) function for the other two.Afterwards, 
//a magic number 4 appears in the calculations and distorts the answer.Maybe you should start using this algorithm for your 
//SMS messages too!
//You are given three numbers A, B, C, where B is actually the secret code symbol.
//•	If the code is 2 – find the remainder after A is divided by C.Example: A = 5, C = 3, A % C = 2.
//•	If the code is 4 – find the sum of A and C.Example: A = 5, C = 3, A + C = 8.
//•	If the code is 8 – find the product of A and C.Example: A = 5, C = 3, A* C = 15.
//After you find the result R from the code transformation, if R can be divided by 4 with remainder 0, 
//find R divided by 4. Otherwise find the remainder after R is divided by 4. 
//For example, if R is 16, it can be divided by 4 with no remainder, so the answer is 4. If R is 9, 
//it cannot be divided by 4, so the answer is 1.
//Input
//The input data should be read from the console.
//On the first input line you will receive the positive integer A.
//On the second input line you will receive the positive integer B.
//On the third input line you will receive the positive integer C.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//If R can be divided by 4 with no remainder, on the first output line you should print R divided by 4.
//Otherwise, on the first output line you should print the remainder after R is divided by 4.
//On the second output line, you should print R.
//Constraints
//•	A, B and C will be positive integers between 1 and 999 999, inclusive.
//•	Allowed working time for your program: 0.10 seconds.Allowed memory: 16 MB.



//Examples
//Input example Output example
//10
//2
//6	1
//4

//6
//4
//3	1
//9




namespace Problem1_248
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            BigInteger res = 0;
            switch (b)

            {
                case 2: res = a % c; break;
                case 4: res = a + c; break;
                case 8: res = (BigInteger)a * (BigInteger)c; break;

                default:; break;
            }
            if (res % 4 == 0)
            {
                Console.WriteLine(res / 4);
            }
            else
            {
                Console.WriteLine(res % 4);
            }
            Console.WriteLine(res);
        }
    }
}
