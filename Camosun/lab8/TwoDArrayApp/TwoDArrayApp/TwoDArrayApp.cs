using System;
using static System.Console;

namespace TwoDArrayApp
{
    class TwoDArrayApp
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[100,2];
            Random n = new Random();
            int num;

            for (int x = 0; x < numbers.GetLength(0); x++)
            {                
                num =  n.Next(100);

                numbers[x,0] = num;                
                numbers[x,1] = num*num;                
            }

            Display(numbers);
            ReadKey();

        }

        static void Display(int[,] num) 
        {
            WriteLine("Random Values Squares\n");            
            WriteLine("Random\t\tNumber");
            WriteLine("Number\t\tSquared");
            WriteLine("------------------------");

            for (int x = 0; x < num.GetLength(0); x++)
            {
                for (int y= 0; y < num.GetLength(1); y++)
                {
                    if (y==0)
                    {
                        Write("{0,6}", num[x, y]);
                    }
                    else
                    {
                        Write("{0,15}", num[x, y]);
                    }                    
                }
                WriteLine();
            }

        }
    }
}
