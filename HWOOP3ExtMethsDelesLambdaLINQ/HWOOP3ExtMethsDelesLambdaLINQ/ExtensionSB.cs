using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace HWOOP3ExtMethsDelesLambdaLINQ
{
    public static class ExtensionSB
    {
        public static string Substring(this StringBuilder Sb, int index, int length)
        {
            if (index + length >= Sb.Length || index < 0 || length < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            StringBuilder result = new StringBuilder();

            for (int i = index; i <= index + length; i++)
            {
                result.Append(Sb[i]);
            }
            return result.ToString();
        }
    }
}
