using System;

//This problem is simple.You are given a text with some digits.Your task is to find all digits in every odd position 
//(starting from zero) throughout the text and calculate their sum.
//Input
//The input data should be read from the console.
//On the only input line you will receive the text.
//The input data will always be valid and in the format described.There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//On the only input line you should print the total amount of digits in odd positions and their sum separated by space.
//Constraints
//•	The text’s length will be a valid integer number.
//•	Allowed working time for your program: 0.10 seconds.Allowed memory: 16 MB.
//Examples
//Input example Output example
//123	1 2
//10000	2 0
//987654	3 18
//5005005	3 5
//200000020	4 2


namespace Nightmare_on_Code_Street
{
    class Program
    {
        static void Main()
        {
            string street = Console.ReadLine();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < street.Length; i++)
            {
                if (i % 2 != 0 && (street[i]>='0' && street[i]<='9'))
                {
                    sum += (street[i] -'0');
                    count++;
                }
            }

            Console.WriteLine("{0} {1}",count,sum);
        }
    }
}
