using System;
using System.Numerics;

class SaddyCooper
{
    static void Main()
    {
        string strNum = Console.ReadLine();
        int transcount = 0;

        while(strNum.Length >1 && transcount < 10)
        { 
        BigInteger product = 1;
            int temp = strNum.Length;
            while (temp > 0 )
            {               
                 strNum = strNum.Substring(0, strNum.Length - 1);
                int sum = 0;
                for (int i = 0; i < strNum.Length; i += 2)
                {
                    sum += (strNum[i] - '0'); //input[i] - '0'  - transform char to int
                }
                 if (sum != 0)
                {
                    product *= sum;
                }
                transcount++;
                strNum = product.ToString();
                temp--;
            }
            if (transcount <10)
            {
                Console.WriteLine(transcount);
            }
            Console.WriteLine(strNum);
        }
    }
}

