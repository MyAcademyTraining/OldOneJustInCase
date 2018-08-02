using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SecretNumSystem
{
    class Program
    {
        static string ConvertToNum(string input)
        {
            StringBuilder sb = new StringBuilder();

            int j = 0;
            #region whileCycle;
            while (j < input.Length)
            {
                //case zoro
                if (input[j] == 'z')
                {
                    sb.Append('6');
                    j += "zoro".Length;
                }
                //case pesho
                else if (input[j] == 'p')
                {
                    sb.Append('2');
                    j += "pesho".Length;
                }
                //case tosho
                else if (input[j] == 't')
                {
                    sb.Append('1');
                    j += "tosho".Length;
                }
                //case vladimir
                else if (j < (input.Length - 5) && input[j] == 'v' && input[j + 5] == 'm')
                {
                    sb.Append('7');
                    j += "vladimir".Length;
                }
                //case Vlad
                else if (input[j] == 'v')
                {
                    sb.Append('4');
                    j += "vlad".Length;
                }
                //case Haralampi
                else if (input[j] == 'h' && j < (input.Length - 7) && input[j + 4] == 'l')
                {
                    sb.Append('5');
                    j += "haralampi".Length;
                }
                //case Hristofor
                else if (input[j] == 'h' && j < (input.Length - 7) && input[j + 6] == 'f')
                {
                    sb.Append('3');
                    j += "hristofor".Length;
                }
                else
                {
                    sb.Append('0');
                    j += "hristo".Length;
                }
            }
            #endregion
            return sb.ToString();

        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',').ToArray();
            string[] converted = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
                converted[i] = ConvertToNum(input[i]);
            }
            BigInteger product = 1;
            foreach (var number in converted)
            {
                product *= toDecimal(number);
            }
            Console.WriteLine(product);
        }

        static BigInteger toDecimal(string input)
        {
            {
                BigInteger result = 0;
                foreach (var num in input)
                {
                    int digit;
                    digit = num - '0';
                    result = 8 * (BigInteger)result + (digit);

                }
                return result;
            }
        }
    }
}

