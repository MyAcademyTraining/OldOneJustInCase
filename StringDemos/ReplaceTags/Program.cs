using System;
using System.Text;

//Description

//Write a program that replaces in a HTML document given as string all the tags
//<a href="URL">TEXT</a> with corresponding markdown notation[TEXT](URL).


class ReplaceTags
{
    static string ReplacingTags(string input)
    {
        StringBuilder sb = new StringBuilder();

        char quite = '"';

        string aTagStart = "<a ";
        int aTagStartLen = aTagStart.Length;
        string aTagEnd = "</a>";
        int aTagEndLen = aTagEnd.Length;

        int inputLen = input.Length;

        int i = 0, cIdx = 0;

        while (i < inputLen)
        {
            cIdx = 0;

            while (cIdx < aTagStartLen 
                && i + cIdx < inputLen
                && aTagStart[cIdx] == input[i + cIdx])
            {
                cIdx++;
            }

            if (cIdx == aTagStartLen)
            {
                StringBuilder tempAddr = new StringBuilder();
                StringBuilder tempCaption = new StringBuilder();

                cIdx = input.IndexOf("href", i) - i;

                while (input[i + cIdx] != quite)
                {
                    cIdx++;
                }
                cIdx++;

                var c = input[i + cIdx];
                while (c != quite)
                {
                    tempAddr.Append(c);
                    cIdx++;
                    c = input[i + cIdx];
                }
                cIdx++;
                
                while (input[i+cIdx]!='>')
                {
                    cIdx++;
                }
                cIdx++;

                c = input[i + cIdx];
                while (c != aTagEnd[0])
                {
                    tempCaption.Append(c);
                    cIdx++;
                    c = input[i + cIdx];
                }

                sb.Append(string.Format("[{0}]({1})", tempCaption, tempAddr));
                i += cIdx + aTagEndLen;
            }
            else
            {
                sb.Append(input[i]);
                i++;
            }
        }

        return sb.ToString();
    }

    static string ReplacingTagsV1(string input)
    {
        int start = input.IndexOf("<a");
        int end = input.IndexOf("/a>", start + 1) + 3;
        string result = input;

        while (start > -1 && end > start)
        {

            string temp = input.Substring(start, end - start);

            result = result.Replace(temp, RearengeString(temp));

            start = input.IndexOf("<a", end);
            end = input.IndexOf("/a>", start + 1) + 3;
        }
        return result;
    }

    static string RearengeString(string htmlTag)
    {
        string text = "";
        string address = "";

        int start, end;

        //start = htmlTag.IndexOf("href") + 6; // "href=\"".Length;
        //char checkForParanthesis = htmlTag[start - 1];
        //string searchedString = string.Format("{0}>", checkForParanthesis);
        //end = htmlTag.IndexOf(searchedString, start);
        start = 9;
        end = htmlTag.IndexOf("\">", start);
        address = htmlTag.Substring(start, end - start);

        start = end + 2;
        end = htmlTag.IndexOf("</a>", start);
        text = htmlTag.Substring(start, end - start);
        return string.Format("[{0}]({1})", text, address);
    }

    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ReplacingTags(input));
    }
}
