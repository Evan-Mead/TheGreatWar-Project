using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Herd
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        Dinosaur dinosaur1 = new Dinosaur("Ducky");


        //Constructor - Sets the scores to 0 when a new game is created

        public Dinosaur(string name)
        {
            this.type = "Ducky";
            health = 120;
            energy = "Energy 25";
            attack_power = 20;
        }

        public Dinosaur(string name)
        {
            this.type = "Petri";
            health = 100;
            energy = "Energy 15";
            attack_power = 20;
        }

        public Dinosaur(string name)
        {
            this.type = "Spike";
            health = 150;
            energy = "Energy 30";
            attack_power = 40;
        }

        //Member Methods - All your methods go below here!


        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
    }
}
