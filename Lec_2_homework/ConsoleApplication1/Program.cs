using System;

namespace ConsoleApplication1
{
    class Program
    {
        //A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        //First name
        //Last name
        //Age(0...100)
        //Gender(m or f)
        //Personal ID number(e.g. 8306112507)
        //Unique employee number(27560000…27569999)
        //Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.Print the data at the console.


        static void Main()
        {
            string First_name = "Name";
            string Family = "Last Name";
            byte age = 100;
            char gen = 'u';
            long pid = 8702186384;

            Console.WriteLine("Required info is: \n {0} {1}, age {2}, gender {3} with ID of {4}", First_name, Family, age, gen, pid);
        }
    }
}
