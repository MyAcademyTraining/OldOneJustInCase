using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWParseTagsLastIndexOF
{
    class Program
    {
        static string FindAndUp(string text)
        {
            StringBuilder sb = new StringBuilder();

            string open = "<upcase>";
            string close = "</upcase>";
            int i = 0;
            int start = text.IndexOf(open);
            int end = text.IndexOf(close, start);
            int textLength = text.Length;
            while (i < textLength)
            {
                while (i != start && i < textLength)
                {
                    sb.Append(text[i]);
                    i++;

                }
                while (i >= start && i < (end + close.Length) && i < textLength)
                {

                    if (i >= start + open.Length && i < (end))
                    {
                        sb.Append(char.ToUpper(text[i]));
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
                start = text.IndexOf(open, end);
                end = text.IndexOf(close, start + 1);

                if (i < textLength)
                {
                    sb.Append(text[i]);
                    i++;
                }
                else
                {
                    break;
                }
                //Console.WriteLine(sb); useful for debug
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.IndexOf("upcase") != -1)
            {
                Console.WriteLine(FindAndUp(input));
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
