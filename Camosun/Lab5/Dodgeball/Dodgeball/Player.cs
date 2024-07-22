using System;
using static System.Console;

namespace Dodgeball
{
    class Player
    {
        private string namePlayer;
        private float maxThrowRange;
        private int locationPlayer;

        public Player()
        {
        }
        public Player(string nPlayer, float mThrowRange, int lPlayer)
        {
            namePlayer = nPlayer;
            maxThrowRange = mThrowRange;
            locationPlayer = lPlayer;
        }
        public string GsPlayer
        {
            get { return namePlayer; }
            set { namePlayer = value; }
        }
        public float GsMaxThrowRange
        {
            get { return maxThrowRange; }
            set { maxThrowRange = value; }
        }
        public int GsLocation        { 
            get { return locationPlayer; }
            set { locationPlayer = value; }
        }
        public override string ToString()
        {
            return namePlayer + " / " + locationPlayer + " / " + maxThrowRange;
        }
    }
}
