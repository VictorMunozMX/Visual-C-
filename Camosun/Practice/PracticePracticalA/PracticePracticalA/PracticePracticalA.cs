using System;
using static System.Console;

namespace PracticePracticalA
{
    class PracticePracticalA
    {
        static void Main(string[] args)
        {
            // variables
            string strValue;
            int numItems, price;

            // title
            WriteLine("Shipping Charges Application");

            // ask for items
            Write("\nPlease enter the number of items purchased: ");
            strValue = ReadLine();

            // validate the numer
            while (!int.TryParse(strValue, out numItems) || numItems <= 0)
            {
                WriteLine("Problem with input. Please re-enter a number " +
                    "greater than zero.");
                Write("Please enter the number of items purchased: ");
                strValue = ReadLine();
            }

            // method to calculate the price
            price = GetPrice(numItems);

            // display the total
            WriteLine("\nThe shipping charge for {0} item(s) purchased: {1,2:c}", numItems, price);

            ReadKey();
        }

        // calculate the total of the price
        static int GetPrice(int c)
        {
            int n = 10;

            for (int i = 1; i <= c; i++)
            {
                // for 1 item
                if (i == 1)
                    n = n;

                // betwen 2 and 5 items
                if (i > 1 && i <= 5)
                {
                    n += 5;
                }

                // betwen 6 and 14 items
                if (i > 5 && i < 15)
                {
                    n += 3;
                }

                // more than 14 items
                if (i >= 15)
                {
                    n += 1;
                }
            }
            // return the cost or price
            return n;
        }
    }
}
