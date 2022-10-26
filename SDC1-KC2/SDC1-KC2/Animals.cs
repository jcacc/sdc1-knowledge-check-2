using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC1_KC2
{
    public class Animals
    {
        public string Name;
        public string Species;
        public int Legs;
        public bool canFly;

        

        public Animals(string animalName, string animalSpecies, int animalLegs, bool animalCanFly)
        {
            Name = animalName;
            Species = animalSpecies;
            Legs = animalLegs;
            canFly = animalCanFly;

        }



    }
}
