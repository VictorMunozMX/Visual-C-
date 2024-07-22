using System;
using static System.Console;

namespace PlayerApp
{
    class Player
    {
        // variables
        private int playerID;
        private string fisrtName;
        private string lastName;
        private int numberOfVictories;
        private int numberOfLosses;
        private int numberOfGamesPlayers;
        private float winPercent;
        // constructors
        public Player() 
        { 
        }
        public Player(int ID, string fisrt, string last)
        {
            playerID = ID;
            fisrtName = fisrt;
            lastName = last;            
        }
        // accessors
        public int GetNumVictories()
        {
            return numberOfVictories;
        }
        public int GetNumLosses() 
        {
            //return GetNumLosses();
            return numberOfLosses;
        }
        public int GetNumGames() 
        {
            return numberOfGamesPlayers;
        }
        // Methods
        public int ScoreGameWin() 
        {
            numberOfGamesPlayers += 1;
            return numberOfVictories += 1;
        }
        public int ScoreGameLoss() 
        {
            numberOfGamesPlayers += 1;            
            return numberOfLosses += 1;
        }
        // private float CalcWinPercent()       // solo uso en clase
        public float CalcWinPercent() 
        {
            winPercent = (numberOfLosses * 100) / numberOfVictories;
            winPercent = (winPercent < 0) ? 0f : winPercent;
            return winPercent;
        }
        // on screen
        public override string ToString()
        {
            return "Player ID: " + playerID + ", name: " + fisrtName + " " + lastName +
                ", games played: " + numberOfGamesPlayers + ", win percent: " + winPercent + "%";
        }
    }
}
