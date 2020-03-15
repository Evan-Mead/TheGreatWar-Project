using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Fleet
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        public Robot robotOne = new Robot("Bender", 100, " LVL. 25", Weapon, 30);
        public Robot robotTwo = new Robot("ClapTrap", 80, "LVL. 20", Weapon, 20);
        public Robot robotThree = new Robot("R2", 120, "LVL. 30", Weapon, 40);

        //Constructor
        //public void()

        //Member Methods - All your methods go below here!
        public Robot()
        {

        }


        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
    }
}
