using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace ReindeerApp
{
    class ReindeerApp
    {
        static void Main(string[] args)
        {

            // instance by Rudolph
            Reindeer reindeer1 = new Reindeer("Rudolph", 2200.5f);            

            // display the result
            WriteLine(reindeer1);

            // instance by Donner
            Reindeer reindeer2 = new Reindeer("Donner", 2100.42f);
            
            // display the result
            WriteLine(reindeer2);            

            // pause to show the results
            WriteLine("Press any key to continue...thanks");
            ReadKey();
        }
    }
}
