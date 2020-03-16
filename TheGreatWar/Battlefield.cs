using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGreatWar
{
    class Battlefield
    {
        string fleet = "Fleet";
        string herd = "Herd";
        int minHealth = 0;
        int maxHealth = 120;
        int fleetHealth;
        int herdHealth;

        public Battlefield()
        {
            fleet = " ";
            herd = " ";
        }

        public int RandomAttacks(int minHealth, int maxHealth)
        {
            Random random = new Random();
            return random.Next(minHealth, maxHealth);
        }

        public string AttackTurns()
        {
            string result = fleet + " " + fleetHealth + " " + herd + " " + herdHealth + " ";
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
            Console.WriteLine(AttackTurns());
            while (fleetHealth < 3 && herdHealth < 3)
            {
                Console.WriteLine(fleet + " attack turn.");
                Console.ReadLine();

                fleetHealth = RandomAttacks(minHealth, maxHealth);
                Console.WriteLine("Attacked for: " + " ");

                Console.WriteLine(herd + " attack turn.");
                Console.ReadLine();

                herdHealth = RandomAttacks(minHealth, maxHealth);
                Console.WriteLine("Attacked for: " + " ");

                BattleDamageAssessment();

                Console.WriteLine();

                Console.WriteLine(AttackTurns());

                BattleWinner();
            }
        }
    }
}