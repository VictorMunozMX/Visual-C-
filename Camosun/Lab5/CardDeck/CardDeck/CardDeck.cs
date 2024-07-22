using System;
using static System.Console;

namespace CardDeck
{
    class CardDeck
    {
        static void Main()
        {
            // variables
            string cad1, cad2;

            // enter the cards
            Write("Enter your card rank (e.g. A for Ace):");
            cad1 = ReadLine();

            Write("Enter your card suit (e.g. S for Spades):");
            cad2 = ReadLine();
            
            // intance the class
            Card nCard = new Card(cad1, cad2);
            
            // show the reult
            WriteLine(nCard);
            ReadKey();

        }
    }
}
