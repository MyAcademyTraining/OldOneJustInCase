﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
    class Dog : Animal, ISound
    {
        public Dog(int age, string name, Sex sex) : base(age, name, sex)
        {
        }

        public void MakeSomeNoise()
        {
            Console.WriteLine($"Bau, bau {this.Name} said");
        }
    }
}
