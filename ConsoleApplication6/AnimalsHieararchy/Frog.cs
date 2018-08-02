using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, Sex sex) : base(age, name, sex)
        {
        }

        public void MakeSomeNoise()
        {
            Console.WriteLine($"I am a prince / princes, kiss me {this.Name} said");
        }
    }
}
