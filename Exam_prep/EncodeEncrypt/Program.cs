using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeEncrypt
{
    class Program
    {        
        static void Main(string[] args)
        {
            string[] encodedText = Console.ReadLine().Split(' ').ToArray();
            int numbersInCodeTable = int.Parse(Console.ReadLine());
            byte[] encodedNumbers = new byte[encodedText.Length];
            for (int i = 0; i < encodedText.Length; i++)
            {
                encodedNumbers[i] = byte.Parse(encodedText[i]);
            }
            string[] inputSymbolAndCode = new string[numbersInCodeTable];
            for (int i = 0; i < numbersInCodeTable; i++)
            {
                inputSymbolAndCode[i] = Console.ReadLine();
            }
            char[] symbols = new char[numbersInCodeTable];
            int[] lengthOfCodeForSymbol = new int[numbersInCodeTable];
            for (int i = 0; i < numbersInCodeTable; i++)
            {
                symbols[i] = inputSymbolAndCode[i][0];
                string temp = inputSymbolAndCode[i].Remove(0,1);
                lengthOfCodeForSymbol[i] = int.Parse(temp);
            }

        }
    }
}
