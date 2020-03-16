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

        public Dinosaur(string type, int health, string energy, Weapon dinosaurAttackOne, Weapon dinosaurAttackTwo, Weapon dinosaurAttackThree)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.dinosaurAttackOne = dinosaurAttackOne;
            this.dinosaurAttackTwo = dinosaurAttackTwo;
            this.dinosaurAttackThree = dinosaurAttackThree;
        }

        //public Dinosaur(Weapon)
        //{
        //    dinosaurAttackOne = new Weapon("Bite", 30);
        //    dinosaurAttackTwo = new Weapon("Slash", 20);
        //    dinosaurAttackThree = new Weapon("Tail Whip", 50);
        //}
    }
}