using System;
using static System.Console;

namespace NumberGuessDouble
{
    class NumberGuess
    {
        
        static void Main()
        {
            
            int maxNumber;
            WriteLine("\nWhat is the maximum number? ");
            int.TryParse(ReadLine(), out maxNumber);
            
            int theUpperBound = maxNumber;
            int myGuess = maxNumber / 2;

            Write("Press 1 to go first: ");
            int option = int.Parse(ReadLine());
            if (option == 1) 
            {
                Machine(maxNumber);
                Person(maxNumber);
            }            
            WriteLine("Press any key to continue...\n");
        }   // Main

        static void Machine(int maxNumber)
        {
            int theLowerBound = 1;
            bool endGame = false;
            int guessCount = 0;            
            int theUpperBound = maxNumber;
            int myGuess = maxNumber / 2;

            Random numberR = new Random();
            int numberByGuess = numberR.Next(maxNumber);
            //WriteLine(numberByGuess);

            WriteLine(" Ok, you go first! Good luck\n");
            do
            {
                guessCount++;
                Write("Make your guess: ");
                myGuess = int.Parse(ReadLine());

                if (myGuess == numberByGuess)
                {
                    Write("You got the number!");
                    Write("\nIt took you {0} guesses", guessCount);
                    WriteLine("\nOk, my turn then. Wish me luck!");
                    //ReadKey();
                    endGame = true;
                }
                else
                {
                    if (myGuess < numberByGuess)
                    {
                        WriteLine("Is your number to low.");
                        theLowerBound = myGuess;
                    }
                    else
                    {
                        WriteLine("Is your number to high.");
                        theUpperBound = myGuess;
                    }
                    myGuess = (theLowerBound + theUpperBound) / 2;
                }
            } while (!endGame);
            
        }

        static void Person(int maxNumber)
        {
            int theLowerBound = 1;
            bool endGame = false;
            int guessCount = 0;           
            int theUpperBound = maxNumber;
            int myGuess = maxNumber / 2;

            Write("\nPick a number between 1 and {0}.", maxNumber);
            Write("\nPress space when you are ready!\n");
            ReadKey();
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
        }
    }                          
}
