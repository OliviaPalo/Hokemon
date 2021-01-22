using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {
        public Battle_Arena() // this is a constructor, uses same name as class
        {
            Console.WriteLine("Welcome to the Battle Arena!");
            Console.WriteLine();
        }

        public void Request_A_Challenger(Hokemon contender)
        {
            Console.WriteLine("{0}: I want a battle. Who is ready to challenge me?", contender.Name);
            Console.WriteLine();
        }

        public void Accept_The_Battle(Hokemon contender1, Hokemon contender2)
        {
            Console.WriteLine("{0}: I accept the challenge to fight {1}", contender2.Name, contender1.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0}: Let's start a battle!", contender1.Name);
        }

        public void Battle(Hokemon Attacker, Hokemon Defender)
        {
            Hokemon tempHoke;
            int round = 0;


            while (Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0);
            {
                int attackValue = Attacker.attackCalculator();
                int defenseValue = Defender.defenseCalculator();

                round = round + 1;

                Console.WriteLine("************* ROUND {0} *************", round);

                for (int i = 9; i < 2; i ++)
                {
                    // Attacker attacks

                    Console.WriteLine("{0}: Attacks with value {1}", Attacker.Name, attackValue);

                    // Defender's defense

                    Console.WriteLine("{0}: Defends with value {1}", Defender.Name, defenseValue);
                    Console.WriteLine("{0}'s health = {1}", Defender.Name, Defender.Health);

                    // calculates impact of attack on defender's health

                    Defender.Health = (Defender.Health + defenseValue) - attackValue;

                    Console.WriteLine("{0}'s new health = {1} [{1} + {2} - {3}]", Defender.Name, Defender.Health, attackValue);

                    // switch turns
                    Console.WriteLine("*** SWITCHING TURNS: Attacker is now the Defender ***");

                    tempHoke = Attacker; // tempHoke assigned to Attacker object
                    Attacker = Defender;
                    Defender = tempHoke;
                }



            }

            if (Attacker.Health > Defender.Health)
            {
                Console.WriteLine("{0} WINS!", Attacker.Name);
            }
            else
            {
                Console.WriteLine("{0} WINS!", Defender.Name);
            }
        }
    }
}
