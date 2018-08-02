using System;
using System.Text;

//Description

//Write a program that extracts from a given text all sentences containing given word.
//Input

//    On the first line you will receive a string - the word
//    On the second line you will receive a string - the text

//Output

//    Print only the sentences containing the word on a single line


class ExtractSentance
{
    static string GetSentancesContWord(string[] separetedInp, string searched)
    {
        StringBuilder result = new StringBuilder();
        int searchLen = searched.Length;
        for (int i = 0; i < separetedInp.Length; i++)
        {
            string current = separetedInp[i].Trim();
            int temp = current.IndexOf(searched);

            while (temp != -1)
            {
                if ((temp == 0 || !char.IsLetter(current[temp - 1]))
                    && ((temp + searchLen == current.Length)
                        || !char.IsLetter(current[temp + searchLen])))
                {
                    result.AppendFormat("{0}. ", current);
                    break;
                }
                temp = current.IndexOf(searched, temp + searchLen);
            }
        }

        return result.ToString();
    }

    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string separator = ".";
        string[] splitedSentance = text.Split(new string[] { separator }, StringSplitOptions.None);
        string result = GetSentancesContWord(splitedSentance, word.Trim());
        Console.WriteLine(result);
    }
}
