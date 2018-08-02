using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassSystemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat();
            cat1.Age = 5;

            var cat2 = new Cat();
            cat2.Age = 5;
            Console.WriteLine(cat1 == cat2); //
            Console.WriteLine(cat1.Equals(cat2));
            var clonedCat = cat1.Clone() as Cat;
            Console.WriteLine(clonedCat.Age);
            var owner = new Owner();
            var prop = typeof(Console).GetProperties();
            foreach (var item in prop)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Owner
    {
        public Owner Memberwise()
        {
            return (Owner)this.MemberwiseClone();
        }
    }


    public class Cat : ICloneable
    {
        public int Age { get; set; }

        public static bool operator ==(Cat firstCat, Cat seconfCat)
        {
            return firstCat.Equals(seconfCat);
        }

        public static bool operator !=(Cat firstCat, Cat seconfCat)
        {
            return !firstCat.Equals(seconfCat);
        }

        public override bool Equals(object obj)
        {
            var otherCat = (Cat)obj;
            return this.Age == otherCat.Age;
        }

        public object Clone()
        {
            var clone = new Cat();
            {
                Age = this.Age;
            }
            return clone;
        }


    }

}
