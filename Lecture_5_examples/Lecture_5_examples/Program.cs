using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Lecture_5_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //double age = 29.458;
            //string name = "Pesho";
            //string city = "na mainata si";
            //Console.WriteLine(">{0,-10}< is {1:f2} years old and live in {2}",name,age,city);

            //int input = Console.Read();
            //Console.WriteLine('a'<= input && input <='z');
            //ConsoleKeyInfo input_key = Console.ReadKey();
            //Console.WriteLine(input_key.Key);


            //string input = Console.ReadLine();

            //int num = int.Parse(input);
            //int num = int.Parse(input); // Same for all numeric data type

            //int num = int.Parse(Console.ReadLine()); //Same as above
            //Console.WriteLine(num * 2);


            // Console.WriteLine("Input a number");
            //int num = int.Parse(Console.ReadLine());
            // int num = Convert.ToInt32(Console.ReadLine()); Equivialent to the upper

            //  string binary = Convert.ToString(num, 2).PadLeft(32, '0');

            //Console.WriteLine("Number {0} to bin is {1}",num, binary);


            //Console.WriteLine("Input a number");
            //string input = Console.ReadLine();
            //int value ;  

            //if (int.TryParse(input,out value)) // Return boolean value -dali e int i  int (value) 
            //{
            //    Console.WriteLine("Valid number: {0}",value);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is invalid number",input);
            //}


            //int isnumber;
            //string input;

            //do
            //{
            //    Console.WriteLine("Enter number");
            //    input = Console.ReadLine();

            //} while (!int.TryParse(input,out isnumber) ); //  The idea is to flip the output of TryParse

            //Console.WriteLine("Number is {0}", isnumber);


            // Sledvashtata zadacha izpolzva System.text, ako sme go iztrilei

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Това е кирилица");

            // Izpolzva System.Threading i System.Globalization.

            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("BG-BG");

            //Console.WriteLine("{0 :c}", 123);

            //Izpolzva System.Globalization

            string input = "21.10.2019 18:23";
            DateTime date= DateTime.ParseExact(input, "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture);

            //Console.WriteLine(date);
            //Console.WriteLine("{0:MM.yy}",date);  //different formating from the same input

            Console.WriteLine("{0:dd dddd MMMM yyyy}", date);  //now we have a weekdeay



        }
    }
}
