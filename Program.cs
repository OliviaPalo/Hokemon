using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hokeworld!");
            Console.WriteLine();

            // instantiate new Hokemon object (player 1)
            Hokemon hoke01 = new Hokemon(); 
            hoke01.get_details();
            hoke01.about();
            Console.WriteLine();

            // delays
            System.Threading.Thread.Sleep(1000); 

            // instantiate new Hokemon object (player 2)
            Hokemon hoke02 = new Hokemon(); 
            hoke02.get_details();
            hoke02.about();
            Console.WriteLine();
            

            /*
            Halor halorHoke01 = new Halor(); // inherits from Halor
            halorHoke01.get_details();

            Hokemon hoke04 = new Hokemon(); // instantiation from Hokemon class

            // demonstrating polymorphism with about method
            // a Hokemon instance hoke04
            // a halor instance halorHoke01
            hoke04.about();
            halorHoke01.about();
            */

            // creates the object firstArena from Battle_Arena class
            Battle_Arena firstArena = new Battle_Arena(); 

            firstArena.Request_A_Challenger(hoke01);

            System.Threading.Thread.Sleep(3000);

            firstArena.Accept_The_Battle(hoke01, hoke02);

           


            
        }
    }
}
