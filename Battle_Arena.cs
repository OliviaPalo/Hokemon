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
            Console.WriteLine();
            System.Threading.Thread.Sleep(250);
            Console.WriteLine("{0}: Let's start a battle!", contender1.Name);
            Console.WriteLine();
        }

        public void Battle(Hokemon Attacker, Hokemon Defender)
        {
            Hokemon tempHoke;
            int round = 0;


            while (Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0)
            {
                int attackValue;
                int defenseValue;

                round = (round + 1);

                Console.WriteLine("************* ROUND {0} *************", round);

                for (int i = 0; i < 2; i++)
                {
                    attackValue = Attacker.attackCalculator();
                    defenseValue = Defender.defenseCalculator();

                    // Attacker attacks

                    Console.WriteLine("{0}: Attacks with value {1}", Attacker.Name, attackValue);

                    // Defender's defense

                    Console.WriteLine("{0}: Defends with value {1}", Defender.Name, defenseValue);
                    Console.WriteLine("{0}'s health = {1}", Defender.Name, Defender.Health);

                    // calculates impact of attack on defender's health

                    Defender.Health = (Defender.Health + defenseValue) - attackValue;

                    Console.WriteLine("{0}'s new health = {1}", Defender.Name, Defender.Health, attackValue);
                    Console.WriteLine();

                    // switch turns
                    if ((((Attacker.Health > 0) & (Defender.Health > 0))) & (round != 10))
                    {
                        Console.WriteLine("----- SWITCHING TURNS -----");

                        tempHoke = Attacker; // tempHoke assigned to Attacker object
                        Attacker = Defender;
                        Defender = tempHoke;

                        Console.WriteLine();
                    }
                }

                if (Attacker.Health <= 0)
                {
                    if (Defender.Health > Attacker.Health)
                    {
                        Console.WriteLine("{0} WINS!", Defender.Name);
                        Environment.Exit(0);
                    }
                }
                else if (Defender.Health <= 0)
                {
                    if (Attacker.Health > Defender.Health)
                    {
                        Console.WriteLine("{0} WINS!", Attacker.Name);
                        Environment.Exit(0);
                    }
                }

                if (round == 10)
                {
                    if ((Attacker.Health <= 0) || (Defender.Health > Attacker.Health))
                    {   
                        Console.WriteLine("END OF BATTLE! {0} WINS!", Defender.Name);
                        Environment.Exit(0);                    
                    }
                    else if ((Defender.Health <= 0) || (Attacker.Health > Defender.Health))
                    {
                        Console.WriteLine("END OF BATTLE! {0} WINS!", Attacker.Name);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("END OF BATTLE! IT'S A TIE!");
                    }

                }

                //if ((Attacker.Health > Defender.Health) || (Defender.Health <= 0))
                //{
                //    Console.WriteLine("{0} WINS!", Attacker.Name);
                //    Environment.Exit(0);
                //}
                //else if ((Defender.Health > Attacker.Health) || (Attacker.Health <= 0))
                //{
                //    Console.WriteLine("{0} WINS!", Defender.Name);
                //    Environment.Exit(0);
                //}
            }

        }
    }
}
