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
        public Weapon dinosaurAttackOne;
        public Weapon dinosaurAttackTwo;
        public Weapon dinosaurAttackThree;
        public int attack_power;

        public Dinosaur(string type, int health, string energy, Weapon dinosaurAttackOne, Weapon dinosaurAttackTwo, Weapon dinosaurAttackThree, int attack_power)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.dinosaurAttackOne = dinosaurAttackOne;
            this.dinosaurAttackTwo = dinosaurAttackTwo;
            this.dinosaurAttackThree = dinosaurAttackThree;
            this.attack_power = attack_power;
        }
    }
}