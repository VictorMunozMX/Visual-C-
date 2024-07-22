using System;
using static System.Console;

namespace NumberGuess
{
    class NumberGuess
    {
        static void Main()
        {
            int theLowerBound = 1;
            bool endGame = false;
            int guessCount = 0;            
            int maxNumber = 21;            
            int theUpperBound = maxNumber;
            int myGuess = maxNumber / 2;
                     
            do
            {
                guessCount++;
                Write("Is your number {0} ? ", myGuess);
                if (ReadLine().ToUpper() == "Y")
                {
                    Write("I got your number!");
                    Write("\nIt took me {0} guesses", guessCount);
                    ReadKey();
                    endGame = true;
                }
                else
                {
                    Write("Is your number (H)igher or (L)ower? ");
                    switch (ReadLine().ToUpper())
                    {
                        case "H":
                            theLowerBound = myGuess;
                            break;
                        case "L":
                            theUpperBound = myGuess;
                            break;
                        default:
                            break;
                    }
                    myGuess = (theLowerBound + theUpperBound) / 2;
                }
            } while (!endGame);
            WriteLine("Press any key to continue...");
        }
    }
}
