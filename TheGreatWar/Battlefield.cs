using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Battlefield
    {
        //public Fleet();
        //public Herd();
        int minHealth = 0;
        int maxHealth = 300;
        int fleetHealth;
        int herdHealth;

        public Battlefield()
        {
            //fleet = new Fleet();
            //herd = new Herd();
        }

        public int RandomAttacks(int minHealth, int maxHealth)
        {
            Random random = new Random();
            return random.Next(minHealth, maxHealth);
        }

        public string Attack()
        {
            string result = " " + fleetHealth + " " + herdHealth;
            return result;
        }

        public void BattleDamageAssessment()
        {
            if (fleetHealth > herdHealth)
            {
                Console.WriteLine("Robots win the round.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Dinosaurs win the round.");
                Console.ReadLine();
            }
        }
        
            public void BattleWinner()
        {
            if (fleetHealth > herdHealth)
            {
                Console.WriteLine("Fleet wins the battle!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Herd wins the battle!");
                Console.ReadLine();
            }
        }
        public void RunBattle()
        {
            Console.WriteLine("This is a simulated battle between a fleet of robots and a herd of dinosaurs.");

            while (fleetHealth < 3 && herdHealth < 3)
            {
                Console.WriteLine("Fleet attack turn.");
                Console.ReadLine();

                fleetHealth = RandomAttacks(minHealth, maxHealth);
                Console.WriteLine("Fleet attacked for: " + Attack());

                Console.WriteLine("Herd attack turn.");
                Console.ReadLine();

                herdHealth = RandomAttacks(minHealth, maxHealth);
                Console.WriteLine("Herd attacked for: " + Attack());

                BattleDamageAssessment();

                Console.WriteLine();

                Console.WriteLine(Attack());

                BattleWinner();
            }
        }
    }
}