using System;
using System.Security.Cryptography;
using static System.Console;

namespace Capacity
{
    class Capacity
    {
        static void Main()
        {
            // Variables
            int itemWeight1, itemWeight2, itemWeight3,
                itemCount1, itemCount2, itemCount3;

            // Method for obtein weight and count
            itemWeight1 = GetWeight(1);
            itemWeight2 = GetWeight(2);
            itemWeight3 = GetWeight(3);
            itemCount1 = GetCount(1);
            itemCount2 = GetCount(2);
            itemCount3 = GetCount(3);

            // Method to calculate the weight total
            int total = CalculateResult(itemWeight1, itemWeight2, itemWeight3, itemCount1, itemCount2, itemCount3);         
            WriteLine("The total weight of all items is {0}.", total);
            WriteLine("\nEnter to end the program...");
            ReadKey();
        }

        // obtain weight by item
        static int GetWeight(int item)
        {
            Write("Enter the Weight of item {0}: ", item);
            int c = int.Parse(ReadLine());
            return c;
        }
        //obtain count by item
        static int GetCount(int item)
        {
            Write("How many of item {0}: ", item);
            int c = int.Parse(ReadLine());
            return c;
        }

        //  Ccalculate the total
        static int CalculateResult(int i1, int i2, int i3, int c1, int c2, int c3)
        {
            int r = ((i1*c1) + (i2 * c2) + (i3 * c3));
            return r;
        }          
    }
}
