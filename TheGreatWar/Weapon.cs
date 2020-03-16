using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Weapon
    {
        public string robotAttackOne;
        public string robotAttackTwo;
        public string robotAttackThree;
        public string dinosaurAttackOne;
        public string dinosaurAttackTwo;
        public string dinosaurAttackThree;
        public int attack_power;

        public Weapon(string robotAttackOne, string robotAttackTwo, string robotAttackThree, string dinosaurAttackOne, string dinosaurAttackTwo, string dinosaurAttackThree, int attack_power)
        {
            this.robotAttackOne = robotAttackOne;
            this.robotAttackTwo = robotAttackTwo;
            this.robotAttackThree = robotAttackThree;
            this.dinosaurAttackOne = dinosaurAttackOne;
            this.dinosaurAttackTwo = dinosaurAttackTwo;
            this.dinosaurAttackThree = dinosaurAttackThree;
            this.attack_power = attack_power;
        }
    }
}