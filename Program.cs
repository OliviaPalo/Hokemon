using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hokeworld!");
            Hokemon hoke01 = new Hokemon(); // instantiate new Hokemon object
            hoke01.get_details();
        }
    }
}
