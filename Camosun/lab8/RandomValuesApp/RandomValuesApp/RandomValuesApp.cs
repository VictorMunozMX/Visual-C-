using System;
using static System.Console;

namespace RandomValuesApp
{
    class RandomValuesApp
    {
        static void Main(string[] args)
        {
            // variables
            int numX, numY;

            // obtain data
            Write("Could you write the number of rows, between (1 and 20): ");
            numX = int.Parse(ReadLine());

            Write("Could you write the number of columns, between (1 and 20): ");
            numY = int.Parse(ReadLine());

            // create the array
            int[,] ArrayTwo = new int[numX, numY];

            // create the isnatance and enviar el arreglo
            Arrays arr = new Arrays();
            arr.Values = ArrayTwo;
            
            Display(arr.GetValues());             
            ReadLine();
        }

        static void Display(int[,] arr)
        {
            int a=0, b=0, max = 0;
            Write("\nRandom Generated Values");            
            Write("\nCol");

            // write the number of columns
            for (int x=0; x < arr.GetLength(1); x++)
            {
                Write("{0,10}",x+1);
            }
            WriteLine();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Write("Row {0}",i+1);   // number of row

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write("{0,10}", arr[i,j]);   
                                
                    // find the major number
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        a = i;
                        b = j;
                    }
                }
                WriteLine();
            }
            WriteLine("\nLargest Value: {0}", max);
            WriteLine("Row {0}",a+1);
            WriteLine("Col {0}",b+1);

        }
       
    }
}
