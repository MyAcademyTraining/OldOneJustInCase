using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            var utils = new Utils(logger);   
        }
    }

    internal class ConsoleLogger : ILoger // Razkachihme se ot konzolata, za da mojem da testvame
    {
        public ConsoleLogger()
        {
        }

        public void Write()
        {
            Console.WriteLine("Test");
        }
    }

    class Utils
    {
        private ILoger logger;

        public Utils(ILoger logger)
        {
            this.logger = logger;
        }

        public string CapitalizeText(string message)
        {
            this.logger.Write(); // Tova triaba da go zamenim, ako se praveshe neshto s nego.

            return message.ToUpper();
        }
    }

    interface ILoger
    {
        void Write();
    }
}
