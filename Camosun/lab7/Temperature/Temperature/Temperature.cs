using System;
using static System.Console;

namespace Temperature
{
    class Temperature
    {
        static void Main()
        {
            int[] weeklyTemps = { 20, 21, 18, 17, 15, 16, 15 };

            TemperatureApp tempTest = new TemperatureApp(weeklyTemps);

            Console.WriteLine(" Lowest Temp: {0}", tempTest.FindColdestTemp().ToString("F0"));
            Console.WriteLine(" Highest Temp: {0}", tempTest.FindWarmestTemp().ToString("F0"));
            Console.WriteLine(" Press any key to see the final test...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(tempTest);
            Console.ReadKey();
        }
    }
}
