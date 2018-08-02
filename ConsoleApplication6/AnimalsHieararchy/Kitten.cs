using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
    class Kitten : Cat
    {
        public Kitten(int age, string name, Sex sex) : base(age, name, sex)
        {
            if (sex != Sex.Female)
            {
                Console.WriteLine("This is not a Kitten, dude");
            }
        }
    }
}
