using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Herd
    {
        public Dinosaur dinosaurOne;
        public Dinosaur dinosaurTwo;
        public Dinosaur dinosaurThree;
        public Weapon dinosaurAttackOne;
        public Weapon dinosaurAttackTwo;
        public Weapon dinosaurAttackThree;

        public Herd()
        {
            dinosaurOne = new Dinosaur("Long Neck", 100, "NRG 25", dinosaurAttackOne, dinosaurAttackTwo, dinosaurAttackThree);
            dinosaurTwo = new Dinosaur("Fly Guy", 80, "NRG 20", dinosaurAttackOne, dinosaurAttackTwo, dinosaurAttackThree);
            dinosaurThree = new Dinosaur("Chompy Dude", 120, "NRG 30", dinosaurAttackOne, dinosaurAttackTwo, dinosaurAttackThree);
            //dinosaurAttackOne = new Weapon("Bite", 30);
            //dinosaurAttackTwo = new Weapon("Slash", 20);
            //dinosaurAttackThree = new Weapon("Tail Whip", 50);
        }
    }
}
    