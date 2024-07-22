using System;
using static System.Console;

namespace Dragon
{
    class ClassDragon
    {
        private string dragonName;
        private int dragonAge;
        private float flightSpeedKPH;
        private bool breatheFire;
        private string dragonColour;

        // default constructor
        public ClassDragon()
        { 
        }
        // second constructor with one param
        public ClassDragon(string Name) { 
            dragonName = Name;
        }
        // second constructor with all params
        public ClassDragon(string name, int age, float flight, bool fire, string colour) {
            dragonName = name;
            dragonAge = age;
            flightSpeedKPH = flight;
            breatheFire = fire;
            dragonColour = colour;
        }
        // access to member name
        private int GetAge() { 
            return dragonAge;
        }
        // access to member flight
        private float GetSpeed() {
            return flightSpeedKPH;
        }
        // access to member breath
        private bool GetBreath()
        {
            return breatheFire;
        }
        // access to last member colour, 
        private string GetColour()
        {
            return dragonColour;
        }
        // Show all the members
        public override string ToString() 
        {
            return "Dragon name: " + dragonName + ", Age: " + dragonAge + ", speed: " +
                flightSpeedKPH + " kph, breath fire: " + breatheFire + ", colour: " + dragonColour;
        }
        
    }
}
