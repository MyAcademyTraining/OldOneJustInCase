using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDec
{
    class Program
    {
        static int HexToDec(string input)
        {
            int result = 0;
            foreach (var num in input)
            {

                int digit;
                if (char.IsDigit(num))
                {
                    digit = num - '0';
                }
                else
                {
                    digit = num - 'A' + 10;
                }
                result = 16 * result + (digit);

            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] tests = 
                {
                    "123",
                    "1AB",
                    "124",                    
            };
            foreach (var test in tests)
            {
                Console.WriteLine(HexToDec(test));
            }

        }
    }
}
