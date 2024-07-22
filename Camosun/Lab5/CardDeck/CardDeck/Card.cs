using System;
using static System.Console;

namespace CardDeck
{
    class Card
    {
        // members
        private string rank;
        private string suit;    

        // constructors
        public Card() 
        {
        }
        public Card(string c1, string c2)
        {
            rank = c1;
            suit = c2;            
        }
        // Methods
        public string LeyendCard()
        {
            string sRank, sSuit;
            
            switch (rank.ToUpper())
            {
                case "A":
                    sRank = "Ace";
                    break;
                case "2":
                    sRank = "Two";
                    break;
                case "3":
                    sRank = "Three";
                    break;
                case "4":
                    sRank = "Four";
                    break;
                case "5":
                    sRank = "Five";
                    break;
                case "6":
                    sRank = "Six";
                    break;
                case "7":
                    sRank = "Seven";
                    break;
                case "8":
                    sRank = "Eight";
                    break;
                case "9":
                    sRank = "Nine";
                    break;
                case "T":
                    sRank = "Ten";
                    break;
                case "J":
                    sRank = "Jack";
                    break;
                case "Q":
                    sRank = "Queen";
                    break;
                case "K":
                    sRank = "King";
                    break;
                default:
                    sRank = "Unknown";
                    break;
            }

            switch (suit.ToUpper())
            {
                case "S":
                    sSuit = "Spades";
                    break;
                case "H":
                    sSuit = "Hearts";
                    break;
                case "D":
                    sSuit = "Diamonds";
                    break;
                case "C":
                    sSuit = "Clubs";
                    break;
                default:
                    sSuit = "Unknown";
                    break;
            }
            return sRank + " of " + sSuit;
        }

        public override string ToString()
        {
            return "\nYour card is the " + LeyendCard() + ".";
        }
    }
}
