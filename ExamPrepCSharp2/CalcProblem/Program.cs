using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CalcProblem
{
    class Program
    {
        static BigInteger ConvertToDec(string input)
        {
            BigInteger result = 0;

            int radix = 23;
            foreach (var num in input)
            {
                int digit;
                digit = num - 'a';
                result = radix * result + digit;
            }
            return result;
        }

        static List<char> ConvFromDec(BigInteger decNumber)
        {
            int targetNumericalSystem = 23;
            BigInteger temp = 0;
            List<char> result = new List<char>();
            do
            {
                temp = decNumber % targetNumericalSystem;
                result.Add((char)(temp + 'a'));
                decNumber /= targetNumericalSystem;
            }
            while (decNumber > 0);
            result.Reverse();
            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] temp = input.Split(' ');
            BigInteger sum = 0;
            foreach (var line in temp)
            {
                if (line != string.Empty)
                {
                    sum += ConvertToDec(line);
                }
            }
            List<char> output = ConvFromDec(sum);
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in output)
            {
                sb.Append(symbol);
            }
            Console.WriteLine("{0} = {1}", sb.ToString(), sum);
        }
    }
}