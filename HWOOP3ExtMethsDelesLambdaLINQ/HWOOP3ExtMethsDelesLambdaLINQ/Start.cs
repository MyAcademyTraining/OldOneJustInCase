using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWOOP3ExtMethsDelesLambdaLINQ
{
    class Start
    {
        static void Main()
        {
            // Test the Extension of StringBuilder class
            StringBuilder test = new StringBuilder();

            string testString = "This is a test string for stringBuilder Overload";
            test.Append(testString);
            Console.WriteLine(test.Substring(10, 4));
            
            // Test the Extensions of IEnumerable
            int[] testOfIEnum = new int[] { 1, 2, 3, -5 };
            Console.WriteLine(testOfIEnum.Min());
            Console.WriteLine(testOfIEnum.Max());
            Console.WriteLine(testOfIEnum.Prod());
            Console.WriteLine(testOfIEnum.Sum());
        }
    }
}
