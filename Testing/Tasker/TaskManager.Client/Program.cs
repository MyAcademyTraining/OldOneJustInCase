using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskManager.Models;

namespace TaskManager.Client
{
    class Program
    {
        static void Main()
        {
            var fileLogger = new FileLogger();
            var consoleLogger = new ConsoleLogger();
            var idProvider = new IdProvider();

            var taskManager = new Tasker(consoleLogger,idProvider);

            var task1 = new taskManager.Models.Task("Kupi hlqb");
            var task2 = new taskManager.Models.Task("IzmiiKolata", DateTime.Now.AddDays(2));
            var task3 = new taskManager.Models.Task("Kupi bira", DateTime.Now);

            taskManager.save(task1);
            taskManager.save(task2);
            taskManager.Delete(2);
            taskManager.save(task3);
        }
    }
}
