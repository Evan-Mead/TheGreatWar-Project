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
        public Fleet robotOne = new Robot("Bender", 100, " LVL. 25", Weapon, 30);
        public Fleet robotTwo = new Robot("ClapTrap", 80, "LVL. 20", Weapon, 20);
        public Fleet robotThree = new Robot("R2", 120, "LVL. 30", Weapon, 40);

        //Constructor - Sets the scores to 0 when a new game is created

    //    public Bender(string name, double health, string power_level, string weapon, double attack_power);
    //    {
    //        health = 120;
    //        power_level = "Level 25";
    //        weapon = "Fist";
    //        attack_power = 30;
    //    }

    //public Robot(string name)
    //{
    //    this.name = "R2";
    //    health = 100;
    //    power_level = "Level 15";
    //    weapon = "Hologram";
    //    attack_power = 20;
    //}

    //public Robot(string name)
    //{
    //    this.name = "T-100";
    //    health = 150;
    //    power_level = "Level 30";
    //    weapon = "Laser";
    //    attack_power = 40;

    //    //Member Methods - All your methods go below here!


    //    //This is the main method that is called in the Program when you press Start
    //    //Call your other methods inside this method
    //}
}
