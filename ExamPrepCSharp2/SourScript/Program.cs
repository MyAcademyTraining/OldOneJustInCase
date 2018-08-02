using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourScript
{
    class Program
    {
        static List<string> Text;
        static bool AreInCurlyBracket;
        static bool AreInString;

        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Text = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                string currentLine = string.Empty;
                currentLine = Console.ReadLine();
                // Processing Comments And AddingThemToTheList
                ProcessComment(currentLine);

                //check if it is Empty
                if (currentLine == string.Empty)
                {
                    i++;
                }
                TextProcessing(currentLine);

                Text.Add(currentLine);
            }
        }

        private string TextProcessing(string currentLine)
        {
            currentLine = currentLine.Trim();
            StringBuilder sb = new StringBuilder();
            int indexOfCurlyOpen = currentLine.IndexOf('{');
            int indexOfCurlyClose = currentLine.IndexOf('}');
            if (indexOfCurlyOpen != -1)
            {
                AreInCurlyBracket = true;
                string[] temp = currentLine.Split(' ');
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = temp[i].Trim();
                    if (temp[i] == "."
                        || temp[i] == "("
                        || temp[i]==")"
                        || temp[i]==";"
                        || temp[i] == "'")

                    {
                        sb.Append(currentLine);
                    }
                    sb.AppendFormat(" {0}", temp[i]);                   
                }
                string result = sb.ToString();
                return result;
            }

            else if (AreInCurlyBracket == true )
            {
                sb.Append(' ', 4);
                string[] temp = currentLine.Split(' ');
                for (int i = 0; i < currentLine.Length; i++)
                {
                    
                    if (temp[i]==)
                    {

                    }
                }
            }
        }

        private static string ProcessComment(string input)
        {
            input = input.Trim();
            string commentStart = "//";
            int indOfStartingComment = input.IndexOf(commentStart);
            if (indOfStartingComment == -1 ||
                indOfStartingComment == 0)
            {
                return input;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = indOfStartingComment; j < input.Length - 1; j++)
                {
                    sb.Append(input[j]);
                    if (input[j] == '/' && input[j + 1] == '/')
                    {
                        StringBuilder comment = new StringBuilder();
                        comment.Append(input, j, input.Length);
                        Text.Add(comment.ToString());
                        return sb.ToString();
                    }
                    sb.Append(input[j]);
                }
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}

