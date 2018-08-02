using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(PrintLinesOnConsole);
            thread.Start();
            // Ececutes on main thread;
            while (true)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("[MainThread] Hi!");
            }
           
        }
        public static void PrintLinesOnConsole()
            {
            while (true)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("[SecThread] Hi!");
            }
        }
    }
}
