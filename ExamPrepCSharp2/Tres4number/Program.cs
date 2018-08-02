using System;
using System.Numerics;
using System.Text;

namespace Tres4number
{
    class Program
    {
        
        static void Main(string[] args)
        {
            BigInteger input = 0;
            try
            {
                 input = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return;
            }
            
            string outputToconvert = DecimalToNinth(input);
            string converter = ConvertToTres(outputToconvert);
            Console.WriteLine(converter);
        }

        private static string ConvertToTres(string outputToconvert)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in outputToconvert)
            {
                switch (item)
                {
                    case '0': sb.Append("LON+"); break;
                    case '1': sb.Append("VK-"); break;
                    case '2': sb.Append("*ACAD"); break;
                    case '3': sb.Append("^MIM"); break;
                    case '4': sb.Append("ERIK|"); break;
                    case '5': sb.Append("SEY&"); break;
                    case '6': sb.Append("EMY>>"); break;
                    case '7': sb.Append("/TEL"); break;
                    case '8': sb.Append("<<DON"); break;
                }
            }
            string output = sb.ToString();
            return output;
        }

        static string DecimalToNinth(BigInteger decValue)
        {
            string Ninth = string.Empty;

            do
            {
                BigInteger bit = decValue % 9;
                Ninth = bit + Ninth;
                decValue /= 9;

            } while (decValue != 0);

            return Ninth;
        }
    }
}
