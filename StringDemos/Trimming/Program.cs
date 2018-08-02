using System;


    class Trimming
    {
        static void Main(string[] args)
        {
        string text = "         sesesssdesds fefe gt     ";
        Console.WriteLine(text.Trim() + "-");
        Console.WriteLine(text.TrimStart() + "-");
        Console.WriteLine(text.TrimEnd()+"-");
        string text2 = "________*+_______awawaw_ds__";
        Console.WriteLine(text2.Trim('_','*','+'));
    }
    }

