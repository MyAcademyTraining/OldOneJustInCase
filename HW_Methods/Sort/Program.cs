using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{

    static int[] SelctionSort(int[] array)
    {
        int temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j]<array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                temp = array[i];
                array[i] = array[minIndex] ;
                array[minIndex] = temp;
            }
        }
        return array;
    }

    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] output = new int[inputArray.Length];
        output = SelctionSort(inputArray);
        for (int i = 0; i < output.Length; i++)
        {
            Console.Write("{0} ",output[i]);
        }
    }
}

