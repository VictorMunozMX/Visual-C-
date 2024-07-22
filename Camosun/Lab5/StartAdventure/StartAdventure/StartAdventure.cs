using System;
using static System.Console;

namespace StartAdventure
{
    class StartAdventure
    {
        static void Main()
        {
            // variables
            string nameAvatar, sNumber;
            int startLocation;
            
            Write("Enter your avatar name: ");
            nameAvatar = ReadLine();

            Write("{0}, select your start location: (1-6) ", nameAvatar);
            sNumber = ReadLine();

            // validate the number 
            int.TryParse(sNumber, out startLocation);            
            switch (startLocation)
            {
                case 1:
                    WriteLine("\nOK {0}... you are in a dimly lit and freezing ice cave filled with hungry penguins", nameAvatar);
                    break;
                case 2:
                    WriteLine("\nOK {0}... you are in a stranger labyrinth of high walls. You smell oranges and cherries nearby..", nameAvatar);
                    break;
                case 3:
                    WriteLine("\nOK {0}... you are in a stranger labyrinth of high walls. You smell oranges and cherries nearby..", nameAvatar);
                    break;
                case 4:
                    WriteLine("\nOK {0}... you are in a stranger labyrinth of high walls. You smell oranges and cherries nearby..", nameAvatar);
                    break;
                case 5:
                    WriteLine("\nOK {0}... you are in a stranger labyrinth of high walls. You smell oranges and cherries nearby..", nameAvatar);
                    break;
                case 6:
                    WriteLine("\nOK {0}... you are in a stranger labyrinth of high walls. You smell oranges and cherries nearby..", nameAvatar);
                    break;
                default:
                    WriteLine("\nOops. You need to select a number between 1 and 6 only.");
                    break;
            }
            ReadKey();
            
        }
    }
}