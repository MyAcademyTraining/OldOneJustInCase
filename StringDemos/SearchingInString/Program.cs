using System;
using System.Collections.Generic;

namespace SearchingInString
{
    class Program
    {
        static List<int> AllIndexes(string text,string searchedValue)
        {
            List<int> indexes = new List<int>();
            Console.WriteLine("All indexes:");
            int currentIndex = text.IndexOf(searchedValue,0);
            while (currentIndex != -1)
            {
                indexes.Add(currentIndex);
                currentIndex = text.IndexOf(searchedValue,currentIndex+1);
            }
            return indexes;
        }
        static void Main(string[] args)
        {
            string sentance = "This is test string and it is testing smthng koksoksoakaokfok test";
            int index = sentance.IndexOf("test"); //result 8 - proverqva za celiya!! string "test" i vryshta pyrvata poziciya
            Console.WriteLine(index);
            int middle = sentance.Length / 2;
            int index2 = sentance.IndexOf("test",middle);
            Console.WriteLine(sentance.LastIndexOf("test",middle)); // Tyrsi ot middle na lqvo
            Console.WriteLine(index2);

            Console.WriteLine(string.Join(", ",AllIndexes(sentance, "test")));

            // 

        }
    }
}
