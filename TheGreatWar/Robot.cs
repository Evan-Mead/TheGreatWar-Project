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
        public int attack_power;

        public Robot(string name, int health, string power_level, Weapon robotAttackOne, Weapon robotAttackTwo, Weapon robotAttackThree, int attack_power)
        {
            this.name = name;
            this.health = health;
            this.power_level = power_level;
            this.robotAttackOne = robotAttackOne;
            this.robotAttackTwo = robotAttackTwo;
            this.robotAttackThree = robotAttackThree;
            this.attack_power = attack_power;
        }
    }
}