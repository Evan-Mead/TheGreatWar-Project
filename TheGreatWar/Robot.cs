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
        private string v1;
        private int v2;
        private string v3;
        private Weapon weapon;
        private int v4;

        public Robot(string name, string power_level, double attack_power)
        {
            this.name = name;
            this.power_level = power_level;
            this.attack_power = attack_power;
        }

        public Robot(string v1, int v2, string v3, Weapon weapon, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.weapon = weapon;
            this.v4 = v4;
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

        public void Run()
        {

        }
    }
}
