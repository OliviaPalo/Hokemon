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
    }
}
