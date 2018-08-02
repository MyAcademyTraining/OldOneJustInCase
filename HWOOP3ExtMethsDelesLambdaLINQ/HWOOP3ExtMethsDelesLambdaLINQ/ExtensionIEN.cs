using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2. IEnumerable extensions

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.


namespace HWOOP3ExtMethsDelesLambdaLINQ
{
   public static class ExtensionIEN 
    { 

        // Calculating sum in IEnumerable
        public static T Sum<T>(this IEnumerable<T> iEnum) where T: struct
        {
            T sum = (dynamic)0;
            foreach (var item in iEnum)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        // Calculating product in IEnumerable
        public static T Prod<T>(this IEnumerable<T> iEnum) where T : struct
        {
            T product = (dynamic)1;
            foreach (var item in iEnum)
            {
                product *= (dynamic) item;
            }
            return product;
        }

        // Calculating max in IEnumerable
        public static T Max<T>(this IEnumerable<T> iEnum) where T : struct
        {
            T max = default(T);
            foreach (var item in iEnum)
            {
                if (max < (dynamic) item)
                {
                    max = item;
                }
            }
            return max; 
        }

        // Calculating min in IEnumerable
        public static T Min<T>(this IEnumerable<T> iEnum) where T : struct
        {
            T min = iEnum.Max();
            foreach (var item in iEnum)
            {
                if (min > (dynamic)item)
                {
                    min = item;
                }
            }
            return min;
        }

        // Calculating average in IEnumerable
        public static T Average<T>(this IEnumerable<T> iEnum) where T : struct
        {
            T sum = (dynamic)0;
            int number = 0;
            foreach (var item in iEnum)
            {
                sum += (dynamic)item;
                number++;
            }
            return sum/(dynamic)number;
        }
    }
}
