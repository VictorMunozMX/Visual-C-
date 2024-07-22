using System;
using System.Security.Cryptography;
using static System.Console;

namespace Projectile
{
    internal class Projectile
    {
        static void Main()
        {
            // Variables    
            double initVelocity = 50.00;
            double theta = Math.PI / 4;                             //  equal to 45 deg
            const double G = 9.81;
            double timeOfFlight, maxHeight, horizonRange;
            
            // Time of flight
            timeOfFlight = ((2 * initVelocity) * (Math.Sin(theta))) / G;
            // Maximum height reached
            maxHeight = (Math.Pow(initVelocity, 2) * Math.Pow(Math.Sin(theta),2)) / (2*G);
            // Horizontal range
            horizonRange = (Math.Pow(initVelocity, 2) * Math.Sin(2*theta) / G);

            // Title
            WriteLine("\nProjectile Information");
            WriteLine();
            // initial values
            Write("Initial velocity =\t{0,8:f2} m/s", initVelocity);            
            Write("\nLaunch angle     =\t{0,12}", "45.00 deg");
            // time of flight
            Write("\nTime of flight   =\t{0,8:f2} s",timeOfFlight);            
            // max height reached
            Write("\nMax height       =\t{0,8:f2} m", maxHeight);            
            // horiz range
            Write("\nHorizontal range =\t{0,8:f2} m", horizonRange);            
            // end of the program
            WriteLine("\n\nEnd of the program");
            ReadKey();
        }
    }
}
