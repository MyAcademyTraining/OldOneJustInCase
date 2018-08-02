using System;
using System.Numerics;

//Problem 2 – Text to Number
//You are given a text and a number(M). This text can contain digits, Latin letters(both capital and letter case) and any other symbols, 
//except for '@'. The number is used to the parsing of the text.
//Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
//•	If the current character is '@', stop the program and print the RESULT
//•	If the current character is a digit(0-9), then multiply the RESULT by this digit
//•	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
//•	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)
//Input
//The input data is given at the standard input. 
//It consists of two lines:
//•	The first one contains the number M, that is used for the module of the result
//•	The second line contains the text
//The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.
//Output
//Print the result from the parsing (RESULT)
//Constraints
//•	M will always be between 2000 and 10 000
//•	The length of the text will always be less than 100 000
//•	Allowed working time for your program: 0.5 seconds.
//•	Allowed memory: 16 MB.


namespace TextToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int module = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            BigInteger result = 0;
            int temp = 1;
            foreach (char simbol in input)
            {
                if (simbol == '@')
                {
                    break;
                }
                else if (int.TryParse(Convert.ToString(simbol), out (temp)))
                {
                    result *= temp;
                }
                else if (simbol >= 'A' && simbol <= 'Z')
                {
                    result += (simbol - 'A');
                }
                else if (simbol >= 'a' && simbol <= 'z')
                {
                    result += (simbol - 'a');
                }
                else
                {
                    result = result % module;
                }
            }
            Console.WriteLine(result);
        }
    }
}
