using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
    class Tomacat : Cat
    {
        public Tomacat(int age, string name, Sex sex) : base(age, name, sex)
        {
            if (sex !=Sex.Male)
            {
                Console.WriteLine("This is not a Tomcat, dude");
            }
        }
    }
}
