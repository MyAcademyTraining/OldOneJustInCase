using System;
/*
 *PRINT THE ASCII TABLE
 FIND ONLINE MORE INFORMATION ABOUT ASCII (AMERICAN STANDARD CODE FOR INFORMATION INTERCHANGE) AND WRITE A PROGRAM THAT PRINTS THE VISIBLE CHARACTERS OF THE ASCII TABLE ON THE CONSOLE (CHARACTERS FROM 33 TO 126 INCLUDING).
 NOTE: YOU MAY NEED TO USE FOR-LOOPS (LEARN IN INTERNET HOW).
 INPUT
 NONE
OUTPUT
THE 94 CHARACTERS ON SINGLE LINE
 */

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int counter=33; counter < 127; counter++)
            {
                Console.Write((char)counter);
            }
            
        }
    }
}
