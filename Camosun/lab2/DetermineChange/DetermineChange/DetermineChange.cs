using System;
using static System.Console;

namespace DetermineChange
{
    class DetermineChange
    {
        static void Main()
        {
            double note25, note10, note5, note1, changeAmount = .92, res;            

            note25 = (int) (changeAmount / .25);
            res = changeAmount - (note25 * .25);

            note10 = (int) (res / .10);
            res = res - (note10 * .10);

            note5 = (int) (res / .05);
            res = res - (note5 * .05);

            note1 = (int) (res / .01);
            res = res - (note1 * .01);

            WriteLine("\tChanger App");
            WriteLine("Change Amount: {0}",changeAmount);
            WriteLine("\n25 note: {0}", note25);
            WriteLine("10 note: {0}", note10);
            WriteLine(" 5 note: {0}", note5);
            WriteLine(" 1 note: {0}", note1);
            ReadKey();
        }
    }
}
