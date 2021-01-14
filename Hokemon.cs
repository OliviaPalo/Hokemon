using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Hokemon
    {
        // MEMBERS: all attributes, methods, and properties are members of this class

        // VARIABLES: attributes inside a class are also called fields
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        // PROPERTIES: combination of a field and method
        //             keeps variables/attributes private
        //             checks user-input

        public string Name // properties have no parethesis unlike the methods below
        {
            get { return name;  }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        // METHODS

        public Hokemon() // constructor method
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }

        public void get_details()
        {
            Console.WriteLine("Name: {0} \nHealth: {1}/{2} \nAttack: {3} \nSpeed: {4} \nDefense: {5} ", name, health, max_health, attack, speed, defense);
        }

        public void provide_name()
        {
            Console.Write("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();
            int randomValue;
            randomValue = rnd.Next(min_value, max_value);
            return randomValue;
        }

    }
}
