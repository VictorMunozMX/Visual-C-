using System;
using static System.Console;

namespace Problem6
{
    class Problem6
    {
        static void Main()
        {
            int sumEven = 0; // Sum of even numbers 1 to 10.
            int sumOdd = 0; // Sum of odd number 1 to 10.
                            // Loop for each number between 1 and 10.
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven = sumEven + i;
                }
                else
                {
                    sumOdd = sumOdd + i;
                    WriteLine(i);
                }
                
            }
            WriteLine("\nSum of even numbers is {0}.", sumEven);
            WriteLine("Sum of odd numbers if {0}.", sumOdd);
            ReadKey();
        }
    }
}
