using System;


    class Substrng
    {
        static void Main(string[] args)
        {
            string text = "Here is some boring text";

        string substr = text.Substring(4); //  Otrqzva ot 4 simvol (3 poziciya) natam
        string substr2 = text.Substring(4, 5); // Otrqzva 5 simvola, ot 4 - natam
        Console.WriteLine(substr);
        Console.WriteLine(substr2);

        // take symbols from 3 to 10
        int from = 3;
        int to = 10;
        string text2 = "0123456789ABCDEF";
        string result = text2.Substring(from,to-from);
        Console.WriteLine(result);
        }
    }

