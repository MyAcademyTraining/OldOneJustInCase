using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BuildingStrings
{
    static string Repeat(char c, int count)
    {
        StringBuilder result = new StringBuilder();

        while (count > 0)
        {
            result.Append("*");
            result.AppendFormat("--0--");
            count--;
        }
        return result.ToString();
    }

    static void Main()
    {
        //Console.WriteLine(Repeat('*', 4000000));
        Console.WriteLine(Repeat('*', 4));

    }

}

