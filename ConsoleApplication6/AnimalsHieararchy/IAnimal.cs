using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsHieararchy
{
   public interface IAnimal
    {
        int Age { get; set; }
        Sex AnimalSex { get;}
        string Name { get; }
       
    }
   public enum Sex { Male, Female }
}
