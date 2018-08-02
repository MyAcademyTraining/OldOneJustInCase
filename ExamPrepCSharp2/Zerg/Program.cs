using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Program
    {
        static string[] SplitToSubstring(string input)
        {
            string[] sub = new string[input.Length / 4];
            for (int i = 0, j = 0; i < input.Length; i += 4)
            {
                sub[j] = input.Substring(i, 4);
                j++;
            }
            return sub;
        }


        static long ConvertToDec(string[] input)
        {
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case "Rawr": result += 0; break;
                    case "Rrrr": result += Math.Pow(15, input.Length - i - 1); break;
                    case "Hsst": result += 2 * Math.Pow(15, input.Length - i - 1); break;
                    case "Ssst": result += 3 * Math.Pow(15, input.Length - i - 1); break;
                    case "Grrr": result += 4 * Math.Pow(15, input.Length - i - 1); break;
                    case "Rarr": result += 5 * Math.Pow(15, input.Length - i - 1); break;
                    case "Mrrr": result += 6 * Math.Pow(15, input.Length - i - 1); break;
                    case "Psst": result += 7 * Math.Pow(15, input.Length - i - 1); break;
                    case "Uaah": result += 8 * Math.Pow(15, input.Length - i - 1); break;
                    case "Uaha": result += 9 * Math.Pow(15, input.Length - i - 1); break;
                    case "Zzzz": result += 10 * Math.Pow(15, input.Length - i - 1); break;
                    case "Bauu": result += 11 * Math.Pow(15, input.Length - i - 1); break;
                    case "Djav": result += 12 * Math.Pow(15, input.Length - i - 1); break;
                    case "Myau": result += 13 * Math.Pow(15, input.Length - i - 1); break;
                    case "Gruh": result += 14 * Math.Pow(15, input.Length - i - 1); break;
                }
            }

            return (long)result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splited = SplitToSubstring(input);

            Console.WriteLine(ConvertToDec(splited)); ;
        }
    }
}
