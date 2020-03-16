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
        public Weapon attack;
        public int attack_power;

        public Robot(string name, int health, string power_level, Weapon attack, int attack_power)
        {
            this.name = name;
            this.health = health;
            this.power_level = power_level;
            this.attack = attack;
            this.attack_power = attack_power;
        }

        public Weapon robotAttackOne = new Weapon("Fist");
        public Weapon robotAttackTwo = new Weapon("Hologram");
        public Weapon robotAttackThree = new Weapon("Laser");

        public Robot(Weapon robotAttackOne, Weapon robotAttackTwo, Weapon robotAttackThree)
        {
            this.robotAttackOne = robotAttackOne;
            this.robotAttackTwo = robotAttackTwo;
            this.robotAttackThree = robotAttackThree;
        }
    }
}