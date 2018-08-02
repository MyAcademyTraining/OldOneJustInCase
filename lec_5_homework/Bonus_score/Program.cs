using System;

//Write a program that applies bonus score to given score in the range[1…9] by the following rules:

//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is less than 0 or more than 9, the program prints "invalid score".
//Input

//The only input line will contain one integer number - the score
//Output

//Output the score with the applied bonus
//Constraints

//The score will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//2	20
//4	400
//9	9000
//10	invalid score
namespace Bonus_score
{
    class Program
    {
        static void Main()
        {
            string input;
            input = Console.ReadLine();
            int a = int.Parse(input);
            PrintBonusScore(a);
        }

        private static void PrintBonusScore(int a)
        {
            if (a >= 1 && a <= 3)
            {
                Console.WriteLine(a * 10);
            }
            else if (a >= 4 && a <= 6)
            {
                Console.WriteLine(a * 100);
            }
            else if (a >= 7 && a <= 9)
            {
                Console.WriteLine(a * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
