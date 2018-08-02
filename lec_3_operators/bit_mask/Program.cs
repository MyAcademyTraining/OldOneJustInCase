using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bit_mask
{
    class Bit_mask
    {
        static void Main(string[] args)
        {
            int pos = 5;  //position
            int number = 35; //0010 0011

            int mask = 1 << pos; // Bit mask is shifted to the needed position
            int maskandnum = number & mask;
            int bit = maskandnum >> pos;


            Console.WriteLine("For {0}, Bit in posiotion {1} is {2}", number, pos, bit);

        }

    }
}
}
