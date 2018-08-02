using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    var data = new DateTime(); // vzema default stoinost
            //    var data2 = new DateTime

            //    Console.WriteLine(data);
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(0,100));
            }
        }
    }
}
