using System;
using static System.Console;

namespace PracticePracticalC
{
    class Circuit
    {
        // members
        string circuitName, country;
        double lengthKM;
        int corners;
        bool activeStatus;

        // default constructor
        public Circuit()
        {
        }

        // constructor additional
        public Circuit(string circuitName, string country, double length, int corners, bool activeStatus)
        {
            this.circuitName = circuitName;
            this.country = country;
            this.lengthKM = length;
            this.corners = corners;
            this.activeStatus = activeStatus;
        }

        // properties
        public string CharCircuitName
        {
            get { return circuitName; }
            set { circuitName = value; }
        }
        public double CharLength
        {
            get { return lengthKM; }
            set { lengthKM = value; }
        }

        // method ToString
        public override string ToString()
        {
            return "Circuit: " + circuitName + ", " +
                   "Length: " + lengthKM + ", " +
                   "Country: " + country + ", " +
                   "Number of turns: " + corners + ", " +
                   "Active: " + activeStatus;                    
        }
    }
}
