using System;
using static System.Console;

namespace PracticePracticalC
{
    class PracticePracticalC
    {
        static void Main(string[] args)
        {   
            // create the instance type array
            Circuit[] array = new Circuit[3];
            
            // populate the array
            array[0] = new Circuit("Oliver", "Canada", 4.83, 16, true);
            array[1] = new Circuit("Autodromo Hermanos Rodriguez", "Mexico", 4.304, 17, true);
            array[2] = new Circuit("Fuji Speedway", "Japan", 4.563, 16, true);

            // using some properties
            //array[0].CharCircuitName = "Victor";
            //array[0].CharLength = 99.9;
            //Write(array[0].CharCircuitName + " - " + array[0].CharLength);

            WriteLine();
            // display the content 
            foreach (Circuit circuit in array)
            {
                Console.WriteLine(circuit.ToString());  
            }

            ReadKey();
        }
    }
}
