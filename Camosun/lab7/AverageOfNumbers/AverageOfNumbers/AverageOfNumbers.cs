using System;
using static System.Console;

namespace AverageOfNumbers
{
    class AverageOfNumbers
    {
        static void Main()
        {
            const int SAMPLE_SIZE = 10;
            int[] number = new int[SAMPLE_SIZE];
            int total = 0, sum = 0;

            for (int i = 0; i < SAMPLE_SIZE; i++)
            {
                Write("Enter a number #{0}: ", i + 1);
                string inVal = ReadLine();

                if (!int.TryParse(inVal, out number[i]))
                {
                    WriteLine("Your input of \"{0}\" is invalid. Will use zero instead", inVal);
                }
                total = number[i];
                sum = sum + total;
            }            

            WriteLine("\nAverage of numbers is {0:F2}", (float)sum / SAMPLE_SIZE);
            ReadLine();
        }        
    }
}