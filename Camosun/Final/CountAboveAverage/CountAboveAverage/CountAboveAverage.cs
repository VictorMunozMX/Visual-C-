using System;
using static System.Console;

namespace CountAboveAverage
{
    class CountAboveAverage
    {
        static void Main(string[] args)
        {
            // variables
            int[] numbers = new int[20];
            double average = 0;

            // funtion to calculate the random numbers
            Random random = new Random();

            // to generate the array with random numbers
            for (int i = 0; i < numbers.Length; i++)
            { 
                numbers[i] = random.Next(10); 
            }

            // display the array and sum the values for calculate the avarege after this cycle
            Write("The numbers are: ");
            foreach (int i in numbers)
            {
                Write("{0} ", i);
                average += i;
            }            

            // display the average
            WriteLine("\n\nThe average is: {0,2:f}.", average /= numbers.Length);

            // counting the values into the array with value major than the average
            int more = 0;
            foreach (int i in numbers)
            { 
                if (i > average)
                    more++;
            }

            // display the number major than average
            WriteLine("\nThe are {0} numbers higher than the average.", more);

            // pause to show the results
            WriteLine("\nPress any key to continue...thanks");
            ReadKey();            

        }
    }
}
