using System;
using static System.Console;

namespace Problem4
{
    internal class Problem4
    {
        static void Main()
        {
            Robot huey = new Robot("123", "Huey", "beep tweet");
            huey.SetBatteryCharge(100);
            huey.ChargeBaterry(45);
            huey.DrainBattery(25);
            
            WriteLine(huey);
            ReadKey();
        }
    }
}
