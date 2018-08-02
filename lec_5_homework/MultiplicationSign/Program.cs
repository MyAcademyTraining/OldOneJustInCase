using System;

//Multiplication sign

//Description

//Write a program that shows the sign(+, - or 0) of the product of three real numbers, without calculating it.

//Use a sequence of if operators.
//Input

//On the first three lines, you will receive the three numbers, each on a separate line
//Output

//Output a single line - the sign of the product of the three numbers
//Constraints

//The input will always consist of valid floating-point numbers
//Time limit: 0.1s
//Memory limit: 16MB

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            string input;
            input = Console.ReadLine();
            float a = float.Parse(input);
            input = Console.ReadLine();
            float b = float.Parse(input);
            input = Console.ReadLine();
            float c = float.Parse(input);
            SingOfFloat(a, b, c);

        }

        private static void SingOfFloat(float a, float b, float c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c > 0)
            {
                Console.WriteLine("+");
            }
        }
    }
}
