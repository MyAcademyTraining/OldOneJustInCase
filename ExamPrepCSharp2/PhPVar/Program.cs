using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhPVar
{
    class Program
    {
        static List<string> PhpCode;


        static void Main(string[] args)
        {
            bool insideComment = false;
            string endOfCode = "?>";

            string endOfComment = @"*/";
            

            PhpCode = new List<string>();
            while (true)
            {
                string currentLine = Console.ReadLine();
                if (currentLine == endOfCode)
                {
                    break;
                }
                if (currentLine.Trim().IndexOf("/*") != -1)
                {
                    while (currentLine.Trim().IndexOf(endOfComment) == -1)
                    {
                        currentLine = Console.ReadLine();
                    }
                }
                if (currentLine.Trim().IndexOf('#') == 0)
                {
                    continue;
                }
                int indexOfVar = currentLine.IndexOf('$');
                while (indexOfVar != -1)
                {

                    int i = indexOfVar + 1;
                    StringBuilder sb = new StringBuilder();
                    while (!char.IsLetterOrDigit((currentLine[i])))
                    {
                        sb.Append(currentLine[i]);
                        i++;
                    }
                    while (char.IsLetterOrDigit((currentLine[i])))
                    {
                        sb.Append(currentLine[i]);
                        i++;
                    }
                    indexOfVar = currentLine.IndexOf('$', i);
                    bool isUnique = true;
                    for (int j = 0; j < PhpCode.Count; j++)
                    {
                        if (sb.ToString() == PhpCode[j])
                        {
                            isUnique = false;
                            continue;
                        }
                    }
                    if (isUnique)
                    {
                        PhpCode.Add(sb.ToString());
                    }

                }

            }
            sortAndPrint();
        }

        private static void sortAndPrint()
        {
            PhpCode.Sort();
            for (int i = 1; i < PhpCode.Count; i++)
            {
                if (PhpCode[i] == PhpCode[i - 1])
                {
                    PhpCode[i] = null;
                }
                PhpCode.Remove(null);
            }
            if (PhpCode[0] == PhpCode[1])
            {
                PhpCode[0] = null;
                PhpCode.Remove(null);
            }
            Console.WriteLine(PhpCode.Count);
            foreach (var item in PhpCode)
            {
                Console.WriteLine(item);
            }
        }
    }

}

