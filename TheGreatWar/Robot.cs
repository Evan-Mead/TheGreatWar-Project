using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Robot
    {
        public string name;
        public int health;
        public string power_level;
        public Weapon robotAttackOne;
        public Weapon robotAttackTwo;
        public Weapon robotAttackThree;

        public Robot(string name, int health, string power_level, Weapon robotAttackOne, Weapon robotAttackTwo, Weapon robotAttackThree)
        {
            this.name = name;
            this.health = health;
            this.power_level = power_level;
            this.robotAttackOne = robotAttackOne;
            this.robotAttackTwo = robotAttackTwo;
            this.robotAttackThree = robotAttackThree;
        }

        //public Robot(Weapon)
        ////{
        ////    robotAttackOne = new robotAttackOne("Fist", 30);
        ////    robotAttackTwo = new Weapon("Hologram", 20);
        ////    robotAttackThree = new Weapon("Laser", 50);
        ////}
    }
}