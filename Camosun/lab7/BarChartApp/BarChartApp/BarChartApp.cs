using System;
using static System.Console;

namespace BarChartApp
{
    class BarChartApp
    {
        static void Main(string[] args)
        {
            // Variables
            int val;
            int[] countNumber = new int[10];

            // Display instructions
            DisplayInstructions();

            // process number
            ProcessEntries(countNumber);

            // display reuslt
            DisplayArray(countNumber);

            WriteLine("\nPress ENTER to quit...");
            ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("This application will allow you to enter any\n" +
            "number of entries between 1 and 10.\n\n" +
            "When you stop entering values, a frequency\n" +
            "distribution showing the number of times each\n" +
            "value was entered will be displayed.");
            Console.WriteLine("\n\tTo stop entering values type Q or q\n");
            Console.Write("\n\n\nPress any key when you are ready to begin...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int GetValue()
        {
            int number;
            string inVal;

            Write("Input any number between 1 and 10 (Q to stop): ");
            inVal = ReadLine().ToUpper();
            if (inVal == "Q")
            {
                return -1;
            }
            while ((!int.TryParse(inVal, out number)) || (number < 1 || number > 10))
            {
                Write("Invalid data - re-enter number [1 to 10] (Q to stop): ");
                inVal = ReadLine().ToUpper();
                if (inVal == "Q")
                {
                    return -1;
                }
            }              
            return number;
        }

        public static void ProcessEntries(int[] countNumber)
        {
            int num;
            bool moreData = true;
            do
            {                
                num = GetValue();
                if (num == -1)
                {
                    moreData = false;
                }
                else
                {
                    countNumber[num-1] = countNumber[num-1]+1;                                        
                }
            } while (moreData);
        }

        public static void DisplayArray(int[] array)
        {
            Clear();
            Write("\nFrecuency Distribution\n");
            for (int i = 0; i < array.Length; i++)
            {
                string cad = "";
                for (int j = 0; j < array[i]; j++)
                {
                    cad = cad + "*";
                }                
                WriteLine("| {0}    {1}", i+1, cad);
            }            
        }
    }
}
