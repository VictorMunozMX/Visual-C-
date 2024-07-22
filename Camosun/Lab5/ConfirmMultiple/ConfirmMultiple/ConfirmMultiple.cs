using System;
using static System.Console;

namespace ConfirmMultiple
{
    class ConfirmMultiple
    {
        static void Main()
        {
            int numA, numB;
            bool cad;
            string zero = "";

            // instance the class
            Confirm numbers = new Confirm();

            // enter the values and validate 
            numbers.CheckValues();

            // obtain the value
            numA = numbers.NumberOne;
            numB = numbers.NumberTwo;

            // validate the multiple
            cad = numbers.Multiple(numA, numB);

            // condition for value = 0            
            if ((numA == 0 || numB == 0) == true)
            {
                zero = "One or more of your numbers is zero. Please retry.";
            }
            else
            {
                if (cad == true)
                {
                    WriteLine(numB + " is a multiple of " + numA);
                }
                else
                {
                    WriteLine(numB + " is not a multiple of " + numA);
                }
            }
            Write(zero);
            ReadKey();       
        }           
    }
}
