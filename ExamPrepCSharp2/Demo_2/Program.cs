using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {


        static void Main(string[] args)
        {
            string codedMessage = Console.ReadLine();
            string cypherLength = GetChypherLength(codedMessage);
            var WithoutLength = WithoutLengthOfChyper(codedMessage, cypherLength);
            var decoded = Decode(WithoutLength);

        }

        static string GetChypherLength(string all)
        {
            string result = "";
            int i = all.Length - 1;
            while (char.IsDigit(all[i]))
            {
                result = all[i] + result; //Taka si obryshtame stringa.
                i--;
            }
            return result;
        }

        static string WithoutLengthOfChyper(string input, string LengthOfChyper)
        {
            var length = LengthOfChyper.Length;
            var withoutlength = input.Length - LengthOfChyper.Length;

            return input.Substring(0, withoutlength);

        }
        static string Decode(string encoded)
        {
            string result = "";
            for (int i = 0; i < encoded.Length; i++)
            {
                string currentRepeat = "";

                while (char.IsDigit(encoded[i]) == true)
                {
                    currentRepeat += encoded[i];
                    i++;
                }
                if (currentRepeat == "")
                {
                    currentRepeat = "1";
                }
                int ammont = int.Parse(currentRepeat);

                result += new string(encoded[i], ammont);
            }
            return result;
        }
        static string GetChyper(string msgAndChyper, int cypherLen)
        {
            return msgAndChyper.Substring(msgAndChyper.Length - cypherLen);
        }
        _
        static string GetEncryptedPart(string msgAndChyper, int cypherLen)
        {
            return msgAndChyper.Substring(0, msgAndChyper.Length - cypherLen);
        }
        _
       static int CodeOf(char symbol)
        {
            return (symbol - 'A');
        }
        static char CharOf(int code)
        {
            return (char)(code + 'A');
        }
        static string Encrypt(string message, string cypher)
        {
            var result = message.ToCharArray();

            var length = Math.Max(message.Length, cypher.Length);

            for (int i = 0; i < length; i++)
            {
                var newCode = CodeOf(result[i % result.Length]) ^ CodeOf(cypher[i % cypher.Length]);
                var newChar = CharOf(newCode);

                result[i % result.Length] = newChar;
            }

            return string.Join("", result);
        }
    }
}
