using System;
using static System.Console;

namespace DrawRobot
{
    class DrawRobot
    {
        static void Main()
        {
            
            WriteLine("Robot (face)");
            Write("Enter the character for the face: ");
            string symbol = ReadLine();
            
            // instance the class
            Robot rob = new Robot();
            rob.Symbol=symbol;

            // call method to print
            rob.Draw();

            // give a pause
            WriteLine("\nPress any ket to continue...");
            ReadKey();

        }
    }
}
