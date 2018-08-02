using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int LargestLength = 0;
            List<char>[] test = new List<char>[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                LargestLength = (input[i].Length > LargestLength) ? input[i].Length : LargestLength;

            }
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < LargestLength; index++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int currentLetterIndex = input[i].Length - 1 - index;
                    if (currentLetterIndex >= 0)
                    {
                        sb.Append(input[i][currentLetterIndex]);
                    }
                }
            }
            StringBuilder output = new StringBuilder();
            for (int position = 0; position < sb.Length; position++)
            {
                int charPosition = char.ToLower(sb[position]) - 'a' + 1;
                char temp = sb[position];
                sb.Remove(position, 1);
                int newPosition = (position + charPosition)%(sb.Length+1);
                sb.Insert(newPosition, temp);
            }
            Console.WriteLine(sb);
        }
    }
}
