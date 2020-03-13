using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Weapon
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        public string fist;
        public string hologram;
        public string laser;
        
        public Weapon(string fist, string hologram, string laser)
        {
            this.fist = fist;
            this.hologram = hologram;
            this.laser = laser;
        }
        //Constructor
        public Weapon weaponOne = new Weapon("Fist");
        public Weapon weaponTwo = new Weapon("Hologram");
        public Weapon weaponThree = new Weapon("Laser");

        //Member Methods - All your methods go below here!


        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
    }
}
