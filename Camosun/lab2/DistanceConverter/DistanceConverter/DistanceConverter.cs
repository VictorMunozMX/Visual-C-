using System;
using static System.Console;


namespace DistanceConverter
{
    class DistanceConverter
    {
        static void Main()
        {
            // Variables
            double distanceRun = 4.5;

            // Name of app and the initial value
            WriteLine("\n\tDistance Converter App");            
            WriteLine("\nMiles \t\t{0:f2}", distanceRun);
            WriteLine("\n\tEquivalent Values");

            // 1 Mile has 5280 foot
            const int MILE = 5280;                      
            WriteLine("Feet: \t\t{0,10:n0}", MILE * distanceRun);
            
            // 1 foot has 12 inches           
            WriteLine("Inches: \t{0,10:n0}", 12 * MILE * distanceRun);

            // 1 foot has 1.6093 km            
            WriteLine("Kilometers: \t{0,10:n2}", 1.6093 * distanceRun);
            
            // end of the app
            WriteLine("Press any key to continue ...");
            ReadKey();
        }
    }
}
