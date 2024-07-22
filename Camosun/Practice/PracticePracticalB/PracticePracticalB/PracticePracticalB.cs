using System;
using static System.Console;

namespace PracticePracticalB
{
    class PracticePracticalB
    {
        static void Main(string[] args)
        {
            // variables
            Random num = new Random();
            int[,] array = new int[4, 4];
            
            // generate array 2d
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = num.Next(10);
                }
            }
            
            // display array
            DisplayGrid(array);

            // call the method to average and show the result
            WriteLine("\nThe average value of the grid is {0}", CalculateAverage(array));

            ReadKey();
        }

        // display array
        static void DisplayGrid(int[,] array)
        {
            WriteLine("\n\t1\t2\t3\t4");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Write(i + 1);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Write("\t" + array[i, j]);
                }
                WriteLine();
            }
        }

        // calculate the average
        static double CalculateAverage(int[,] array)
        {
            double average = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {             
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    average += array[i, j];
                }                
            }
            average /= array.Length;
            return average;
        }
    }
}
