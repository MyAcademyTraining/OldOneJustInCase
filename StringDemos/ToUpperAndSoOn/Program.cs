using System;


    class Program
    {
        static void Main()
        {
        string text = "tHiS is Some Text";
        string firstLetter = text.Substring(0, 1).ToUpper();
        string rest = text.Substring(1).ToLower();
        Console.Write(firstLetter+rest);
        Console.WriteLine();
        char firstLetterInChar = text[0];
        Console.WriteLine(char.ToUpper(firstLetterInChar)+rest); //ekvivalentno
        }
    }

