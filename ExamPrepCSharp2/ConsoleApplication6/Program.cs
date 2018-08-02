using System;
using System.Numerics;
using System.Collections.Generic;

//https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/Workshops/2016%20Nov%2023%20-%20Arrays%2C%20Methods%20and%20Objects/1.%20Messages

namespace ConsoleApplication6
{
    class Program
    {
        static List<int> Decoding(char[] toDecode)
        {
            string[] code = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            List<int> decoded = new List<int>();
            decoded.Capacity  = toDecode.Length / 3;
            for (int i = 0; i < toDecode.Length; i+=3)
            {
                string temp = "";
                temp = toDecode[i].ToString()+ toDecode[i+1].ToString()+toDecode[i+2].ToString();
                int j = 0;                
                while (true)
                {
                    if (temp == code[j])
                    {
                        decoded.Add(j);
                        break;
                    }
                    j++;
                }
                
            }
            return decoded;
         }
            
         static string Coding(int resultSoFar)
        {
            string[] code = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            int output = 0;
            while (resultSoFar % 10 !=0)
            {

            }
           
        }

        static void Main()
        {
            char[] first = Console.ReadLine().ToCharArray();

            char[] second = Console.ReadLine().ToCharArray();
            char operation = char.Parse(Console.ReadLine());

            BigInteger firstDecoded =  int.Parse(string.Join("", Decoding(first)));
            BigInteger secondDecoded = int.Parse(string.Join("",Decoding(second)));
            BigInteger result;
            if (operation == '+')
            {
                result = firstDecoded + secondDecoded;
            }
            else
            {
                result = firstDecoded - secondDecoded;
            }

        }
    }
}
