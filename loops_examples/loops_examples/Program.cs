using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] num = new int[] { 0, 1, 2, 3};
            //foreach (int n in num)
            //{
            //    Console.WriteLine(n);
            //}

            // !!!!!!!!!! To check:

            //int left = 10;
            //int right = 60;

            //while (left < right)
            //{
            //    int n = left;
            //    bool isPrime = true;

            //    if (n%2==0 && n!=2)
            //    {
            //        isPrime = false;
            //    }              

            //    int possibleDivisor = 3;


            //    while (isPrime && possibleDivisor*possibleDivisor <=  n)
            //    {
            //        if (n % possibleDivisor == 0)
            //        {
            //            isPrime = false;
            //        }

            //        possibleDivisor +=2;
            //        Console.WriteLine(isPrime ?"{0} is prime": "{0} is not prime", n);
            //        left++;
            //    }
            //}             
            //while (true)
            //{
            //    while (true)
            //    {

            //        Console.WriteLine("This is used");
            //        continue;
            //        Console.WriteLine("Never used ");
            //    }
            //    Console.WriteLine("Used with continue. It is used with break only");
            //}


            //// Test with goto. Here test is label
            //test:
            //    Console.WriteLine("test with goto");

            //    // Tons of code
            //    goto test;
            //    Console.WriteLine("Never used");


            // loop with GOTO

            //    int i = 0;

            //      start:
            //    {
            //        if (i < 10)
            //        {
            //            Console.WriteLine(i);
            //            i++;
            //        }
            //        else
            //        {
            //            goto end;
            //        }
            //        goto start;
            //    }
            //end:
            //    {
            //    }



            //// Find all 4 numbers: a+b == c+d;

            //for (int a = 1; a <= 9; a++)            
            //    for (int b = 0 ; b <= 9; b++)
            //        for (int c = 0; c <= 9; c++)
            //            for (int d = 0; d <= 9; d++)
            //                if (a+b == c+d)
            //                {
            //                    Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
            //                }

            for (int a = 1; a <= 9; a++)
                for (int b = 0; b <= 9; b++)
                    for (int c = 0; c <= 9; c++)
                    {
                        var d = a + b - c;
                        if (d >= 0 && d<10 && a + b == c + d)
                            
                        {
                            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                        }
                    }
                        
                          



        }

    }
}
