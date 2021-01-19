using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Halor : Hokemon
    {
        private string team = "Halor";

        public void about() // polymorphism from the Hokemon about method
        {
            Console.WriteLine("I am {0}, part of team {1}!", Name, team);
        }

    }

    
}
