using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotTakoa
{
    class Programp
    {
        static string RemoveComment(string[] input)
        {
            StringBuilder sb = new StringBuilder();
            string commentOnsiglepage = "//";
            string openingComment = "/*";
            string closingComment = "*/";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].IndexOf(commentOnsiglepage) != -1) //remove comments
                {
                    i++;
                }
                if (input[i].IndexOf(openingComment) != -1)
                {
                    do
                    {
                        i++;
                    } while (input[i].IndexOf(closingComment) == -1);
                    i++;
                }
                if (string.IsNullOrWhiteSpace(input[i]))//remove empty lines
                {
                    i++;
                }             
                       
                input[i] = input[i].Trim();
                sb.Append(input[i]);
                sb.AppendLine();
            }
            return sb.ToString();
        }
        
        
        static void Main()
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            string[] unminified = new string[numberOfRows];
            for (int i = 0; i < numberOfRows; i++)
            {
                unminified[i] = Console.ReadLine();
            }
            string withoutComments = RemoveComment(unminified);
        }

    }
}
