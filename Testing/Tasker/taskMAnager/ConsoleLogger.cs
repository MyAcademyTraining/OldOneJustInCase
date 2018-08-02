using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskManager.Models
{
   public class ConsoleLogger :Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
