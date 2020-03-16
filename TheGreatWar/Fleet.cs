using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Fleet
    {
        public Robot robotOne;
        public Robot robotTwo;
        public Robot robotThree;
        public Weapon robotAttackOne;
        public Weapon robotAttackTwo;
        public Weapon robotAttackThree;

        public Fleet()
        {
            robotOne = new Robot("Bender", 100, " LVL. 25", robotAttackOne, robotAttackTwo, robotAttackThree);
            robotTwo = new Robot("ClapTrap", 80, "LVL. 20", robotAttackOne, robotAttackTwo, robotAttackThree);
            robotThree = new Robot("R2", 120, "LVL. 30", robotAttackOne, robotAttackTwo, robotAttackThree);
            //robotAttackOne = new Weapon("Fist", 30);
            //robotAttackTwo = new Weapon("Hologram", 20);
            //robotAttackThree = new Weapon("Laser", 50);
        }
    }
}