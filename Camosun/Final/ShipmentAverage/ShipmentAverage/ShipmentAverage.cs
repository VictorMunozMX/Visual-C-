using System;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Console;

namespace ShipmentAverage
{
    class ShipmentAverage
    {
        static void Main(string[] args)
        {
            // variables with values
            const double JANUARY = 5, FEBRUARY = 8, MARCH = 5, APRIL = 9, MAY = 7;
            double volume;

            // display message
            WriteLine(" Shipments");
            WriteLine(" ---------");
            WriteLine(" Jan {0}", JANUARY);
            WriteLine(" Feb {0}", FEBRUARY);
            WriteLine(" Mar {0}", MARCH);
            WriteLine(" Apr {0}", APRIL);
            WriteLine(" May {0}", MAY);

            // calculate the avarege
            volume = (JANUARY + FEBRUARY + MARCH + APRIL + MAY) / 5;

            // display the result
            WriteLine("The average shipment volume is  {0,2:f}", volume);

            // pause to show the results
            WriteLine("Press any key to continue...thanks");
            ReadKey();

        }
    }
}
