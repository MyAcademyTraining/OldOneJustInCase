using System;
//Exchange numbers

//Description

//Write a program that reads two double values from the console A and B, 
// stores them in variables and exchanges their values if the first one is greater than the second one.Use an if-statement.As a result print the values of the variables A and B, separated by a space.

//Input

//On the first line, you will receive the value of A
//On the second line, you will receive the value of B
//Output

//On the only output line, print the values of the two variables, separated by a whitespace
//Constraints

//A and B will always be valid real numbers between -100 and 100
//Time limit: 0.1s
//Memory limit: 16MB


namespace exchange_numbers
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
            if (a >= b)
            {
                Console.WriteLine("{0} {1}", b ,a );
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }
           
        }
    }
}
