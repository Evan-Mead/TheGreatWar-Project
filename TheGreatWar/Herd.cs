using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Herd
    {
        public Dinosaur dinosaurOne = new Dinosaur("Long Neck", 100, "NRG 25", Weapon, 30);
        public Dinosaur dinosaurTwo = new Dinosaur("Fly Guy", 80, "NRG 20", Weapon, 20);
        public Dinosaur dinosaurThree = new Dinosaur("Chompy Dude", 120, "NRG 30", Weapon, 40);

        public Herd(Dinosaur dinosaurOne, Dinosaur dinosaurTwo, Dinosaur dinosaurThree)
        {
            this.dinosaurOne = dinosaurOne;
            this.dinosaurTwo = dinosaurTwo;
            this.dinosaurThree = dinosaurThree;
        }
    }
}