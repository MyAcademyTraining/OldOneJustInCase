using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class Program
    {
        static Dictionary<int, string> Relevance;

        static char[] Separator = { ',', '.', '(', ')', ';', '-', '!', '?', ' ' };

        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            string[] text = new string[rows];


            Relevance = new Dictionary<int, string>();
            for (int i = 0; i < rows; i++)
            {
                text[i] = Console.ReadLine();
                DivideAndProcess(text[i], searchedWord);
            }
            var result = Relevance.OrderByDescending(i => i.Key);
            
            foreach (KeyValuePair<int, string> kvp in result)
            {
                Console.WriteLine(kvp.Value);
            }      

        }

        private static Dictionary<int, string> DivideAndProcess(string currentLine, string searchedWord)
        {
            try
            {

            
            string[] temp = currentLine.Split(Separator);
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == searchedWord)
                {
                    temp[i] = temp[i].ToUpper();
                    counter++;
                }
                if (temp[i]!="")
                {
                    temp[i] = temp[i].Trim();
                    sb.AppendFormat("{0} ", temp[i]);
                }
            }
            string output = sb.ToString();
            output = output.Trim();
            Relevance.Add(counter, output);
            return Relevance;
            }
            catch (Exception)
            {

                return Relevance;
            }
        }
    }
}
