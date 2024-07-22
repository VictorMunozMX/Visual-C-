using System;
using static System.Console;

namespace ChanceDice
{
    class ChanceCube
    {   
        // variables
        private int faceValue;
        private Random n;
        private const int MAX_SIDES = 6;

        //constructor
        public ChanceCube() 
        {
            faceValue = 1;
        }
        // mut
        public void SetRandom() { 
            n = new Random();
        }
        // Methods
        // this Methods generate a number aleatorie
        public int RollCube()
        {
            faceValue = n.Next(1,MAX_SIDES+1);
            return faceValue;
        }
        // on screen
        public override string ToString()
        {
            return Convert.ToString(faceValue);
        }
    }
}
