using System;
using static System.Console;        // avoid to write the word in every sentence

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // This is my fisrt program en Canada with C#.

            /*WriteLine("Today is Wednesday");
            ReadKey();*/            

            /* \n = new line, \t + tab */

            Write("a\t");
            Write("b\t");
            Write("c\t");
            WriteLine("\nHello");
            //ReadKey();
            // ask for a number
            Write("Enter a number: ");
            // read the number
            string number = ReadLine();
            // print hello plus number
            WriteLine("Hello " + number);
            ReadKey();
        }
    }
}
