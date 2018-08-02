using System;
using System.Numerics;
using System.Collections.Generic;

namespace demo
{
     class Program
    {
        static List<string> EncrpytionKeys = new List<string>() {"cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
        static BigInteger FindResult(BigInteger leftNumber, BigInteger rightNumber, string OpeatorSign)
        {
            BigInteger result = 0;
            switch (OpeatorSign)
            {
                case "+":
                    result = leftNumber + rightNumber;
                    break;
                case "-":
                    result = leftNumber - rightNumber;
                    break;
            }
            return result;
        }

        static string Encrypt(BigInteger number)
        {
            List<string> digits = new List<string>();
            var numberAsString = number.ToString();
            for (int i = 0; i < numberAsString.Length; i++)
            {
                string digit = EncrpytionKeys[numberAsString[i] - '0']; // tuk prevryshtame v int, za indexite  
                digits.Add(digit);
            }
            return string.Join("",digits);
        }

        static BigInteger Decrypt(string encryptedLeftNumber)
        {
            List<int> digits = new List<int>();
            for (int i = 0; i < encryptedLeftNumber.Length; i+=3)
            {
                string digitAsString = encryptedLeftNumber.Substring(i, 3);
                digits.Add(EncrpytionKeys.IndexOf(digitAsString));                
            }
            var digit = BigInteger.Parse(string.Join("", digits));
            return digit;
        }
        static void Main(string[] args)
        {
            string EnctyptedLeftNumber = Console.ReadLine();
                            
           string E
        }
    }
}
