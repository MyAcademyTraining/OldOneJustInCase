using System;

namespace Basics_lec_1
{
    class Basic_lec_1
    {
        static void Main()
        {
            Console.WriteLine("Hallo");
            Console.Write("This is the current date:  ");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter your text:");
            string test = Console.ReadLine();
            Console.WriteLine("test is "+ test);
        }
    }
}
