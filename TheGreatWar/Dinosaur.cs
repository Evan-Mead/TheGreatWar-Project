using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Dinosaur
    {
        public string type;
        public double health;
        public string energy;
        public double attack_power;

        public Dinosaur(string type, double health, string energy, double attack_power)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attack_power = attack_power;
        }

        public void Run()
        {

        }
    }
}
