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
        public int health;
        public string energy;
        public Weapon attack;
        public int attack_power;

        public Dinosaur(string type, int health, string energy, int attack_power)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attack_power = attack_power;
        }



        public Weapon dinosaurAttackOne = new Weapon("Bite");
        public Weapon dinosaurAttackTwo = new Weapon("Slash");
        public Weapon dinosaurAttackThree = new Weapon("Tail Whip");

        public Dinosaur(Weapon dinosaurAttackOne, Weapon dinosaurAttackTwo, Weapon dinosaurAttackThree)
        {
            this.dinosaurAttackOne = dinosaurAttackOne;
            this.dinosaurAttackTwo = dinosaurAttackTwo;
            this.dinosaurAttackThree = dinosaurAttackThree;
        }
    }
}
