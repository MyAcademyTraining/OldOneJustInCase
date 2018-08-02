using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_2_homework
{
    class Program
    {
        //Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
        //©
        //© ©
        //©   ©
        //© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
        static void Main(string[] args)
        {
            string at = "\t  \t\t  @ \r\n \t \t @ \t \t @ \n \r \t @ \t\t @ \t \t @";
            Console.WriteLine(at);
        }
    }
}
