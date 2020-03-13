using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Robot
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class

        public string name;
        public double health;
        public string power_level;
        public string weapon;
        public double attack_power;

        //Constructor - Sets the scores to 0 when a new game is created

        public Robot(string name, double health, string power_level, string weapon, double attack_power)
        {
            this.name = name;
        }

        //Member Methods - All your methods go below here!


        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
    }
}
