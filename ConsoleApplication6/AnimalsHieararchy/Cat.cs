using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
    class Cat : Animal, ISound
    {
        public Cat(int age, string name, Sex sex) : base(age, name, sex)
        {
        }

        public void MakeSomeNoise()
        {
            Console.WriteLine($"Miau, miau {this.Name} said");
        }
    }
}

