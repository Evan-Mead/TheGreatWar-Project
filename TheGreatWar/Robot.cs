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
        public Weapon attack;
        public double attack_power;

        public Robot(string name, double health, string power_level, Weapon attack, double attack_power)
        {
            this.name = name;
            this.health = health;
            this.power_level = power_level;
            this.attack = attack;
            this.attack_power = attack_power;
        }

        static void Main(string[] args)
        {
            Weapon Fist = new Weapon("Punch");
            Weapon Hologram = new Weapon("Blind");
            Weapon Laser = new Weapon("Incinerate");

            Console.WriteLine(Fist.attack);
            Console.WriteLine(Hologram.attack);
            Console.WriteLine(Laser.attack);
        }
    }
}
