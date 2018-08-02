using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GoshoCode
{
    class Program
    {


        static void Main(string[] args)
        {
            string searched = Console.ReadLine();
            searched = searched.Trim();
            int lines = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lines; i++)
            {
                sb.AppendFormat("{0} ", Console.ReadLine());
                //sb.Append(Console.ReadLine());               
            }
            string Text = sb.ToString();
            Text = Text.Replace(" ", string.Empty);

            int whereIsWord = Text.IndexOf(searched);
            int nextDot = Text.IndexOf('.', whereIsWord);
            int nextExclamation = Text.IndexOf('!', whereIsWord);

            if (nextDot != -1 && nextDot < nextExclamation)
            {
                BigInteger result = ProcessDot(Text, searched, whereIsWord);
                Console.WriteLine(result);
            }
            else if (nextDot != -1 && nextExclamation == -1)
            {
                BigInteger result = ProcessDot(Text, searched, whereIsWord);
                Console.WriteLine(result);
            }
            else
            {
                BigInteger result = ProcessExclamation(Text, searched, whereIsWord);
                Console.WriteLine(result);
            }
        }

        private static BigInteger ProcessExclamation(string text, string searched, int whereIsWord)
        {
            BigInteger length = searched.Length;
            int i = whereIsWord - 1;
            BigInteger sum = 0;
            while (char.IsUpper(text[i]) == false)
            {
                sum += (int)text[i] * length;

                i--;
            }
            sum += text[i] * length;
            return sum;

        }

        private static BigInteger ProcessDot(string text, string searched, int whereIsWord)
        {
            int i = whereIsWord + searched.Length;
            BigInteger length = searched.Length;
            BigInteger sum = 0;
            while (text[i] != '.')
            {
                sum += (int)text[i] * length;

                i++;
            }
            return sum;
        }
    }
}
