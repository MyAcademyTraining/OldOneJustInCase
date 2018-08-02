using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
    class Animal : IAnimal
    {

        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get
            {
                return this.Age;
            }

            set
            {
                if (Age <0)
                {
                    throw new ArgumentOutOfRangeException("The Age should be posistive");
                }
                this.Age = value;
            }
        }

        public Sex AnimalSex
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                return this.Name;
            }
            private set { }
        }

        public Sex Sex
        {
            get
            {
                return this.Sex;
            }
            private set { }
        }

        public override string ToString()
        {
            return $"My name is {this.Name}, {this.Age}, I am {this.Sex}";
        }
        
    }

}
