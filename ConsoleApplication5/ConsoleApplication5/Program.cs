using System;

namespace Application
{
    class Data_types
    {
        static void Main()

        {
        byte centuries = 20;
        ushort years = 2000;
        uint days = 730480;
        ulong hours = 17531520;
            char input = '\u0044';
            bool isSmaller = input >= 'a' && input <= 'z';
            string name = "Some string thingies";
            string othname = "Some other thingies";
            string result = string.Format("{0} , {1:d3}", name,othname);
            string sumname = name + othname;
            object test = 1;
            object test2 = 2;
            Console.WriteLine((int)test + (int)test2);
           // Console.WriteLine("Result is {0}" , sumname);
            
        Console.WriteLine(      "{0} cent is {1} years, or {2} days or {3} hours", centuries, years, days, hours);
            Console.WriteLine(result);
            Console.WriteLine(input);
        }
    }
}
