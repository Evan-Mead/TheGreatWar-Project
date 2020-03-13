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
        public double health;
        public string power_level;
        public Weapon weapon;
        public double attack_power;

        public Robot(string name, double health, string power_level, Weapon weapon, double attack_power)
        {
            this.name = name;
            this.health = health;
            this.power_level = power_level;
            this.weapon = Weapon;
            this.attack_power = attack_power;
        }
    }
}
