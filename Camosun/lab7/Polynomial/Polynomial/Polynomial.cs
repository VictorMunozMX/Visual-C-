using System;
using static System.Console;

namespace Polynomial
{
    class Polynomial
    {
        static void Main(string[] args)
        {
            // array defined        
            int[] p1 = { 8, -4, 5, 2 };
            // new array 
            int[] p2 = new int[p1.Length];


            Write("\nEnter a number: ");
            string inVal = ReadLine();
            int number;

            // validate the number
            while (!int.TryParse(inVal, out number))
            {
                Write(" Invalid Number \"{0}\" entered. Please re-enter a number.", inVal);                                
            }

            // Calculate the Poly
            for (int i = 0; i < p1.Length; i++)
            {
                p2[i] = p1[i] * number;
           
            }

            // Show results
            Write("Original array: {0},{1},{2},{3}", p1[0], p1[1], p1[2], p1[3]);
            Write("\n\nModified array: {0},{1},{2},{3}", p2[0], p2[1], p2[2], p2[3]);
            ReadLine();

        }
    }
}
