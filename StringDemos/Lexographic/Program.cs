using System;
namespace Lexographic
{
    class Program
    {
        static string LexCompare(string left, string right) // Sashtoto kato string.compare - vgradena funkcija
        {
            for (int i = 0; i < Math.Min(left.Length, right.Length); i++)
            {
                if (left[i] < right[i])
                {
                    return "First string";
                }
                else if (left[i] > right[i])
                {
                    return "Second string";
                }
            }
            if (left.Length < right.Length)
            {
                return "Second string";
            }
            else if (left.Length > right.Length)
            {
                return "First string";
            }
            return "Equals"; //Totalno ravni sa


        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
        }
    }
}
