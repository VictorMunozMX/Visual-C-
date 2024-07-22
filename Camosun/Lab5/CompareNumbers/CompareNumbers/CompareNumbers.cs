using System;
using static System.Console;

namespace CompareNumbers
{
    class CompareNumbers
    {
        static void Main()
        {
            int a, b, c;

            Compare numbers = new Compare();
            a = numbers.NumberNo(1);
            b = numbers.NumberNo(2);
            c = numbers.NumberNo(3);

            string result = numbers.CompareValues(a,b,c);
            
            WriteLine("\nGiven numbers {0},{1},{2}. Result: {3}", a, b, c,result);
            ReadKey();
        }     
    }
}
