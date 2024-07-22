using System;
using static System.Console;

namespace ReindeerApp
{
    class Reindeer
    {
        // variables
        private string name;
        private float flySpeed;

        // default constructor
        public Reindeer()
        {
        }
        // constructor with both values
        public Reindeer(string n, float f)
        {
            name = n;
            flySpeed = f;            
        }

        // property for FlySpeed 
        public float FlySpeed 
        {
            get { return flySpeed; }
            set { flySpeed = value; }            
        }

        // method toString to show the values like write r writeline
        public override string ToString()
        {
            return "Rindeer " + name + " can fly at speed " + flySpeed + " km/s";
        }
    }
}
