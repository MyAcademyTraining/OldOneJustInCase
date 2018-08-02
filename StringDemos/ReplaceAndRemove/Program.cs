using System;


class ReplaceAndRemove
{
    static void Main(string[] args)
    {
        //string text = "This is some texty text stugg gosho penka ivan csharp...";
        //text.Replace("text", "text2"); //Tova tuk ne se e zapazilo v pametta i text si ima starata stoinost,
        ////zashtoto ne e savenato nikyde, no text= text.Replace("text", "text2") shte raboti
        //string text2 = text.Replace("text", "text2");
        //Console.WriteLine(text);
        //Console.WriteLine(text2);

        //string text3 = "This is some actionscript vbscript stugg gosho javascript ivan script...";
        //Trqbva da replacenem vbscript -> 1; script -> 2 ; javascript -> 3; actionscript -> 4 - pochvame ot naj-dylgija! string
        //string result = text3.Replace("actionscript", "4")
        //                     .Replace("javascript", "3")
        //                     .Replace("vbscript", "1")
        //                     .Replace("script", "2");
        //Console.WriteLine(result);
        //string noVbstript = text3.Replace("vbscript", string.Empty);//zamenjame vbscript s prazen
        //Console.WriteLine(noVbstript);
        string test = "0123456789ABCDEF";
        //int from = 5;
        //int to = 8;
        //Console.WriteLine(test.Remove(from, to-from));
        string result = test.Substring(test.Length - 4); // pochva ot test.length i reje 4 napred
        Console.WriteLine(result);
        Console.WriteLine(test.ToLower());
    }
}

